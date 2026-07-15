// Auth: PBKDF2-hashed passwords via Web Crypto. No plaintext is ever stored.
// Scope note: this is client-side auth for a static demo site. It protects
// stored data from casual inspection, but anyone with the device can clear it.
(function () {
  "use strict";

  const ITERATIONS = 150000;

  function toHex(buf) {
    return Array.from(new Uint8Array(buf)).map((b) => b.toString(16).padStart(2, "0")).join("");
  }

  function fromHex(hex) {
    const out = new Uint8Array(hex.length / 2);
    for (let i = 0; i < out.length; i++) out[i] = parseInt(hex.substr(i * 2, 2), 16);
    return out;
  }

  async function deriveHash(password, saltBytes, iterations) {
    const enc = new TextEncoder();
    const keyMaterial = await crypto.subtle.importKey("raw", enc.encode(password), "PBKDF2", false, ["deriveBits"]);
    const bits = await crypto.subtle.deriveBits(
      { name: "PBKDF2", salt: saltBytes, iterations, hash: "SHA-256" },
      keyMaterial,
      256
    );
    return toHex(bits);
  }

  const EMAIL_RE = /^[^\s@]+@[^\s@]+\.[^\s@]{2,}$/;

  const Auth = {
    validateSignup({ name, email, password }) {
      if (!name || name.trim().length < 2) return "Please enter your full name.";
      if (!EMAIL_RE.test(email || "")) return "Please enter a valid email address.";
      if (!password || password.length < 8) return "Password must be at least 8 characters.";
      return null;
    },

    async signup({ name, email, password }) {
      const invalid = this.validateSignup({ name, email, password });
      if (invalid) return { ok: false, error: invalid };
      if (LibDB.findUserByEmail(email)) return { ok: false, error: "An account with that email already exists." };

      const salt = crypto.getRandomValues(new Uint8Array(16));
      const hash = await deriveHash(password, salt, ITERATIONS);
      const user = LibDB.addUser({
        name: name.trim(),
        email: email.trim().toLowerCase(),
        salt: toHex(salt),
        hash,
        iterations: ITERATIONS
      });
      LibDB.setSession(user.id);
      return { ok: true, user };
    },

    async login(email, password) {
      const user = LibDB.findUserByEmail(email);
      // Demo members seeded into the catalog have no password and cannot log in.
      if (!user || !user.hash) return { ok: false, error: "No account found with that email." };
      const hash = await deriveHash(password || "", fromHex(user.salt), user.iterations);
      if (hash !== user.hash) return { ok: false, error: "Incorrect password." };
      LibDB.setSession(user.id);
      return { ok: true, user };
    },

    logout() {
      LibDB.clearSession();
    },

    currentUser() {
      return LibDB.currentUser();
    },

    requireLogin() {
      if (!this.currentUser()) {
        const next = encodeURIComponent(location.pathname.split("/").pop() + location.search);
        location.href = "login.html?next=" + next;
        return false;
      }
      return true;
    }
  };

  window.Auth = Auth;
})();
