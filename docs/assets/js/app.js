// Page controllers. Each page declares <body data-page="..."> and this file
// wires its interactions to LibDB/Auth. All rendering uses textContent or
// element construction, never string-injected user input.
(function () {
  "use strict";

  const $ = (sel, root) => (root || document).querySelector(sel);
  const $$ = (sel, root) => Array.from((root || document).querySelectorAll(sel));

  function fmtDate(ts) {
    return new Date(ts).toLocaleDateString("en-US", { month: "short", day: "numeric", year: "numeric" });
  }

  function timeAgo(ts) {
    const mins = Math.round((Date.now() - ts) / 60000);
    if (mins < 1) return "just now";
    if (mins < 60) return mins + (mins === 1 ? " minute ago" : " minutes ago");
    const hrs = Math.round(mins / 60);
    if (hrs < 24) return hrs + (hrs === 1 ? " hour ago" : " hours ago");
    const days = Math.round(hrs / 24);
    return days + (days === 1 ? " day ago" : " days ago");
  }

  // ---------- toast ----------
  let toastTimer = null;
  function toast(message, kind) {
    let el = $("#toast");
    if (!el) {
      el = document.createElement("div");
      el.id = "toast";
      el.setAttribute("role", "status");
      document.body.appendChild(el);
    }
    el.textContent = message;
    el.className = "toast-show" + (kind === "error" ? " toast-error" : "");
    clearTimeout(toastTimer);
    toastTimer = setTimeout(() => { el.className = ""; }, 3200);
  }

  // ---------- shared: nav account area ----------
  function renderNavAccount() {
    const slot = $("[data-account]");
    if (!slot) return;
    const user = Auth.currentUser();
    if (!user) return; // keep the static Sign In / Join Library links
    slot.textContent = "";
    const dash = document.createElement("a");
    dash.href = "dashboard.html";
    dash.className = "btn btn-ghost btn-sm";
    dash.textContent = user.name.split(" ")[0];
    const out = document.createElement("button");
    out.className = "btn btn-outline btn-sm";
    out.textContent = "Sign Out";
    out.addEventListener("click", () => { Auth.logout(); location.href = "index.html"; });
    slot.appendChild(dash);
    slot.appendChild(out);
    const burger = $("[data-nav-toggle]");
    if (burger) slot.appendChild(burger);
  }

  // ---------- shared: book card ----------
  function bookCard(book) {
    const card = document.createElement("a");
    card.className = "book-card";
    card.href = "book-detail.html?id=" + book.id;

    const cover = document.createElement("div");
    cover.className = "book-cover cover-" + book.cover;
    const tag = document.createElement("span");
    tag.className = "tag";
    tag.textContent = book.genre;
    cover.appendChild(tag);
    cover.appendChild(document.createTextNode(book.title));

    const body = document.createElement("div");
    body.className = "book-body";
    const h4 = document.createElement("h4");
    h4.textContent = book.title;
    const author = document.createElement("div");
    author.className = "author";
    author.textContent = "by " + book.author;
    const meta = document.createElement("div");
    meta.className = "book-meta";
    const rating = document.createElement("span");
    rating.className = "rating";
    rating.textContent = "★ " + book.rating.toFixed(1);
    const pill = document.createElement("span");
    const available = LibDB.isAvailable(book.id);
    pill.className = "status-pill " + (available ? "status-available" : "status-borrowed");
    pill.textContent = available ? "Available" : "Borrowed";
    meta.appendChild(rating);
    meta.appendChild(pill);
    body.appendChild(h4);
    body.appendChild(author);
    body.appendChild(meta);

    card.appendChild(cover);
    card.appendChild(body);
    return card;
  }

  function renderStats(scope) {
    const s = LibDB.stats();
    $$("[data-stat]", scope).forEach((el) => {
      const key = el.getAttribute("data-stat");
      if (key in s) el.textContent = s[key].toLocaleString();
    });
  }

  // ---------- page: home ----------
  function initHome() {
    renderStats(document);

    const grid = $("#featured-grid");
    if (grid) {
      grid.textContent = "";
      LibDB.getBooks()
        .sort((a, b) => b.rating - a.rating)
        .slice(0, 6)
        .forEach((b) => grid.appendChild(bookCard(b)));
    }

    const form = $("#hero-search");
    if (form) {
      form.addEventListener("submit", (e) => {
        e.preventDefault();
        const q = $("input", form).value.trim();
        const genre = $("select", form).value;
        const params = new URLSearchParams();
        if (q) params.set("q", q);
        if (genre && genre !== "All Genres") params.set("genre", genre);
        location.href = "catalog.html" + (params.toString() ? "?" + params.toString() : "");
      });
    }
  }

  // ---------- page: login ----------
  function initLogin() {
    const params = new URLSearchParams(location.search);
    if (params.get("mode") === "signup") {
      const btn = $('[data-tab="signup"]');
      if (btn) btn.click();
    }

    function showError(form, message) {
      let box = $(".form-error", form);
      if (!box) {
        box = document.createElement("p");
        box.className = "form-error";
        form.insertBefore(box, form.firstChild);
      }
      box.textContent = message;
    }

    function finish() {
      const next = params.get("next");
      location.href = next ? decodeURIComponent(next) : "dashboard.html";
    }

    const signinForm = $("#signin-form");
    if (signinForm) {
      signinForm.addEventListener("submit", async (e) => {
        e.preventDefault();
        const res = await Auth.login($("#email").value, $("#password").value);
        if (res.ok) { toast("Welcome back, " + res.user.name.split(" ")[0]); finish(); }
        else showError(signinForm, res.error);
      });
    }

    const signupForm = $("#signup-form");
    if (signupForm) {
      signupForm.addEventListener("submit", async (e) => {
        e.preventDefault();
        const res = await Auth.signup({
          name: $("#name").value,
          email: $("#email2").value,
          password: $("#password2").value
        });
        if (res.ok) { toast("Account created. Welcome!"); finish(); }
        else showError(signupForm, res.error);
      });
    }
  }

  // ---------- page: catalog ----------
  function initCatalog() {
    const params = new URLSearchParams(location.search);
    const searchInput = $("#catalog-search");
    if (searchInput && params.get("q")) searchInput.value = params.get("q");

    const state = {
      genres: [],
      availability: "all",
      minRating: 0,
      sort: "popular"
    };
    const urlGenre = params.get("genre");

    function readFilters() {
      state.genres = $$(".chip.active[data-genre]")
        .map((c) => c.getAttribute("data-genre"))
        .filter((g) => g !== "All");
      const avail = $$('input[name="availability"]:checked').map((i) => i.value);
      state.availability = avail.length === 1 ? avail[0] : "all";
      const rating = $('input[name="rating"]:checked');
      state.minRating = rating ? Number(rating.value) : 0;
      state.sort = $("#sort-select").value;
    }

    function render() {
      readFilters();
      let books = LibDB.searchBooks(searchInput ? searchInput.value : "", {
        genres: state.genres,
        availability: state.availability,
        minRating: state.minRating
      });
      if (state.sort === "newest") books.sort((a, b) => b.year - a.year);
      else if (state.sort === "title") books.sort((a, b) => a.title.localeCompare(b.title));
      else books.sort((a, b) => b.rating - a.rating);

      const grid = $("#catalog-grid");
      grid.textContent = "";
      books.forEach((b) => grid.appendChild(bookCard(b)));

      const count = $("#result-count");
      if (count) count.textContent = "Showing " + books.length + " of " + LibDB.getBooks().length + " titles";

      if (!books.length) {
        const empty = document.createElement("p");
        empty.style.gridColumn = "1 / -1";
        empty.textContent = "No books match those filters. Try clearing a filter or two.";
        grid.appendChild(empty);
      }
    }

    // genre chips: "All" is exclusive with the rest
    $$(".chip[data-genre]").forEach((chip) => {
      const genre = chip.getAttribute("data-genre");
      if (urlGenre && genre === urlGenre) {
        chip.classList.add("active");
        const all = $('.chip[data-genre="All"]');
        if (all) all.classList.remove("active");
      }
      chip.addEventListener("click", () => {
        if (genre === "All") {
          $$(".chip[data-genre]").forEach((c) => c.classList.remove("active"));
          chip.classList.add("active");
        } else {
          const all = $('.chip[data-genre="All"]');
          if (all) all.classList.remove("active");
          if (!$$(".chip.active[data-genre]").length) {
            if (all) all.classList.add("active");
          }
        }
        render();
      });
    });

    if (searchInput) searchInput.addEventListener("input", render);
    const searchForm = $("#catalog-search-form");
    if (searchForm) searchForm.addEventListener("submit", (e) => { e.preventDefault(); render(); });
    $$('input[name="availability"], input[name="rating"]').forEach((i) => i.addEventListener("change", render));
    $("#sort-select").addEventListener("change", render);
    const reset = $("#reset-filters");
    if (reset) reset.addEventListener("click", () => {
      $$(".chip[data-genre]").forEach((c) => c.classList.toggle("active", c.getAttribute("data-genre") === "All"));
      $$('input[name="availability"]').forEach((i) => { i.checked = false; });
      $$('input[name="rating"]').forEach((i) => { i.checked = false; });
      if (searchInput) searchInput.value = "";
      render();
    });

    render();
  }

  // ---------- page: book detail ----------
  function initDetail() {
    const id = new URLSearchParams(location.search).get("id") || 1;
    const book = LibDB.getBook(id);
    if (!book) { location.href = "catalog.html"; return; }

    document.title = book.title + " · Athenaeum";
    $("#crumb-title").textContent = book.title;
    $("#crumb-genre").textContent = book.genre;
    $("#crumb-genre").href = "catalog.html?genre=" + encodeURIComponent(book.genre);
    $("#detail-cover").className = "detail-cover cover-" + book.cover;
    $("#detail-title").textContent = book.title;
    $("#detail-author").textContent = book.author;
    $("#detail-genre-year").textContent = book.genre + " · " + book.year;
    $("#detail-desc").textContent = book.desc;
    $("#detail-rating").textContent = "★ " + book.rating.toFixed(1);
    $("#stat-pages").textContent = book.pages;
    $("#stat-isbn").textContent = book.isbn;
    $("#details-isbn").textContent = book.isbn;
    $("#details-shelf").textContent = book.genre + ", Aisle " + ((book.id % 6) + 1) + ", Shelf " + "ABCD"[book.id % 4];

    function renderAvailability() {
      const pill = $("#detail-availability");
      const n = LibDB.availableCopies(book.id);
      pill.className = "status-pill " + (n > 0 ? "status-available" : "status-borrowed");
      pill.textContent = n > 0 ? "Available · " + n + (n === 1 ? " copy" : " copies") : "All copies on loan";

      const btn = $("#borrow-btn");
      const user = Auth.currentUser();
      if (user && LibDB.userHasBook(user.id, book.id)) {
        btn.textContent = "On loan to you";
        btn.disabled = true;
      } else if (n <= 0) {
        btn.textContent = "All copies on loan";
        btn.disabled = true;
      } else {
        btn.textContent = "Borrow this book";
        btn.disabled = false;
      }
    }
    renderAvailability();

    $("#borrow-btn").addEventListener("click", () => {
      const user = Auth.currentUser();
      if (!user) {
        location.href = "login.html?next=" + encodeURIComponent("book-detail.html?id=" + book.id);
        return;
      }
      const res = LibDB.borrow(book.id, user.id);
      if (res.ok) toast("Borrowed. Due " + fmtDate(res.loan.dueAt));
      else toast(res.error, "error");
      renderAvailability();
    });

    const related = $("#related-grid");
    related.textContent = "";
    LibDB.getBooks()
      .filter((b) => b.genre === book.genre && b.id !== book.id)
      .slice(0, 3)
      .forEach((b) => related.appendChild(bookCard(b)));
    $("#related-genre").textContent = "More in " + book.genre;
  }

  // ---------- page: dashboard ----------
  function initDashboard() {
    if (!Auth.requireLogin()) return;
    const user = Auth.currentUser();

    $("#welcome-name").textContent = "Welcome back, " + user.name.split(" ")[0] + ".";
    $("#sidebar-name").textContent = user.name;
    $("#sidebar-avatar").textContent = user.name.split(" ").map((p) => p[0]).join("").slice(0, 2).toUpperCase();
    $("#sign-out").addEventListener("click", (e) => {
      e.preventDefault();
      Auth.logout();
      location.href = "index.html";
    });

    renderStats(document);

    // my books
    function renderMyBooks() {
      const panel = $("#my-books");
      panel.textContent = "";
      const loans = LibDB.loansForUser(user.id);
      if (!loans.length) {
        const p = document.createElement("p");
        p.textContent = "You have no books on loan. Browse the catalog to borrow one.";
        p.style.marginBottom = "0";
        panel.appendChild(p);
        return;
      }
      loans.forEach((loan) => {
        const book = LibDB.getBook(loan.bookId);
        const row = document.createElement("div");
        row.className = "activity-item";
        const cover = document.createElement("div");
        cover.className = "mini-cover cover-" + book.cover;
        const info = document.createElement("div");
        info.style.flex = "1";
        const title = document.createElement("strong");
        title.textContent = book.title;
        const due = document.createElement("small");
        const overdue = loan.dueAt < Date.now();
        due.textContent = (overdue ? "Overdue since " : "Due ") + fmtDate(loan.dueAt);
        if (overdue) due.style.color = "var(--color-danger)";
        info.appendChild(title);
        info.appendChild(document.createElement("br"));
        info.appendChild(due);
        const btn = document.createElement("button");
        btn.className = "btn btn-outline btn-sm";
        btn.textContent = "Return";
        btn.addEventListener("click", () => {
          LibDB.returnLoan(loan.id);
          toast("Returned " + book.title);
          refresh();
        });
        row.appendChild(cover);
        row.appendChild(info);
        row.appendChild(btn);
        panel.appendChild(row);
      });
    }

    function renderLoansTable() {
      const tbody = $("#loans-tbody");
      tbody.textContent = "";
      LibDB.recentLoans(5).forEach((loan) => {
        const book = LibDB.getBook(loan.bookId);
        const member = LibDB.getUser(loan.userId);
        const tr = document.createElement("tr");

        const tdBook = document.createElement("td");
        const rowDiv = document.createElement("div");
        rowDiv.className = "book-row";
        const mini = document.createElement("div");
        mini.className = "mini-cover cover-" + (book ? book.cover : 1);
        rowDiv.appendChild(mini);
        rowDiv.appendChild(document.createTextNode(book ? book.title : "Unknown"));
        tdBook.appendChild(rowDiv);

        const tdMember = document.createElement("td");
        tdMember.textContent = member ? member.name : "Unknown";
        const tdDue = document.createElement("td");
        tdDue.textContent = fmtDate(loan.dueAt);
        const tdStatus = document.createElement("td");
        const pill = document.createElement("span");
        if (loan.returnedAt) {
          pill.className = "status-pill status-available";
          pill.textContent = "Returned";
        } else if (loan.dueAt < Date.now()) {
          pill.className = "status-pill status-borrowed";
          pill.textContent = "Overdue";
        } else {
          pill.className = "status-pill status-available";
          pill.textContent = "On time";
        }
        tdStatus.appendChild(pill);

        tr.appendChild(tdBook);
        tr.appendChild(tdMember);
        tr.appendChild(tdDue);
        tr.appendChild(tdStatus);
        tbody.appendChild(tr);
      });
    }

    function renderActivity() {
      const panel = $("#activity-feed");
      panel.textContent = "";
      LibDB.recentEvents(5).forEach((ev) => {
        const item = document.createElement("div");
        item.className = "activity-item";
        const dot = document.createElement("div");
        dot.className = "activity-dot";
        const info = document.createElement("div");
        info.appendChild(document.createTextNode(ev.text));
        info.appendChild(document.createElement("br"));
        const small = document.createElement("small");
        small.textContent = timeAgo(ev.at);
        info.appendChild(small);
        item.appendChild(dot);
        item.appendChild(info);
        panel.appendChild(item);
      });
    }

    function renderGenres() {
      const panel = $("#top-genres");
      panel.textContent = "";
      LibDB.topGenres().forEach((g) => {
        const item = document.createElement("div");
        item.className = "activity-item";
        const name = document.createElement("span");
        name.textContent = g.genre;
        const pct = document.createElement("strong");
        pct.style.marginLeft = "auto";
        pct.textContent = g.pct + "%";
        item.appendChild(name);
        item.appendChild(pct);
        panel.appendChild(item);
      });
    }

    function refresh() {
      renderStats(document);
      renderMyBooks();
      renderLoansTable();
      renderActivity();
      renderGenres();
    }
    refresh();
  }

  document.addEventListener("DOMContentLoaded", () => {
    renderNavAccount();
    const page = document.body.getAttribute("data-page");
    if (page === "home") initHome();
    else if (page === "login") initLogin();
    else if (page === "catalog") initCatalog();
    else if (page === "detail") initDetail();
    else if (page === "dashboard") initDashboard();
  });
})();
