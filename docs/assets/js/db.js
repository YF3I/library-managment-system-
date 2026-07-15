// Data layer: localStorage-backed store. No server; each visitor's data
// lives in their own browser and persists across reloads.
(function () {
  "use strict";

  const KEY = "athenaeum.v1";
  const LOAN_DAYS = 14;

  const SEED_BOOKS = [
    { id: 1,  title: "The Silent Orchard",  author: "Marina Coates",   genre: "Fiction",   year: 2023, rating: 4.8, pages: 342, isbn: "978-1-83947-201-1", copies: 3, cover: 1, desc: "A quiet, aching novel about three sisters who return to their family orchard the summer their mother disappears, and the secrets buried beneath the oldest trees." },
    { id: 2,  title: "Atoms & Ashes",       author: "Dr. R. Feynstein", genre: "Science",  year: 2021, rating: 4.6, pages: 410, isbn: "978-1-83947-202-8", copies: 2, cover: 2, desc: "A sweeping history of the atomic age, from the first chain reaction to the modern reactor, told through the people who lived it." },
    { id: 3,  title: "Empires of Sand",     author: "Halil Demir",     genre: "History",   year: 2019, rating: 4.9, pages: 528, isbn: "978-1-83947-203-5", copies: 4, cover: 3, desc: "The rise and fall of the great desert trade empires, drawn from two decades of archival research across three continents." },
    { id: 4,  title: "The Glass Kingdom",   author: "Wren Ashby",      genre: "Fantasy",   year: 2022, rating: 4.7, pages: 389, isbn: "978-1-83947-204-2", copies: 3, cover: 4, desc: "In a city where every promise becomes glass, a locksmith's apprentice discovers she can break what no one else can touch." },
    { id: 5,  title: "Letters to Myself",   author: "Ines Vartan",     genre: "Biography", year: 2020, rating: 4.5, pages: 276, isbn: "978-1-83947-205-9", copies: 2, cover: 5, desc: "The celebrated architect looks back on fifty years of buildings, failures, and the letters she wrote to her younger self after each one." },
    { id: 6,  title: "Low Tide Notebook",   author: "Sana Iqbal",      genre: "Poetry",    year: 2024, rating: 4.9, pages: 128, isbn: "978-1-83947-206-6", copies: 5, cover: 6, desc: "Poems written over a single year of walking the same stretch of shoreline at low tide." },
    { id: 7,  title: "Harbor Lights",       author: "Priya Nair",      genre: "Fiction",   year: 2018, rating: 4.4, pages: 355, isbn: "978-1-83947-207-3", copies: 3, cover: 1, desc: "Three generations of a lighthouse keeper's family navigate love and distance in a town that is slowly sinking into the sea." },
    { id: 8,  title: "The Quiet Universe",  author: "Tobias Lund",     genre: "Science",   year: 2023, rating: 4.7, pages: 298, isbn: "978-1-83947-208-0", copies: 2, cover: 2, desc: "Why is the night sky silent? A physicist's tour of the great unanswered question of extraterrestrial life." },
    { id: 9,  title: "The Last Caravan",    author: "Amara Solis",     genre: "History",   year: 2017, rating: 4.3, pages: 467, isbn: "978-1-83947-209-7", copies: 2, cover: 3, desc: "Following the final years of the overland silk routes through the eyes of the traders who refused to abandon them." },
    { id: 10, title: "Wren & Willow",       author: "Callum Doyle",    genre: "Fantasy",   year: 2021, rating: 4.6, pages: 402, isbn: "978-1-83947-210-3", copies: 3, cover: 4, desc: "Two rival hedge-witches are forced to share a cottage, a familiar, and eventually a destiny neither of them wanted." },
    { id: 11, title: "A Life in Ink",       author: "Grace Whitfield", genre: "Biography", year: 2022, rating: 4.5, pages: 312, isbn: "978-1-83947-211-0", copies: 2, cover: 5, desc: "The authorized biography of the printmaker who illustrated a century, assembled from her studio journals." },
    { id: 12, title: "Salt & Stone",        author: "Noor Haddad",     genre: "Poetry",    year: 2019, rating: 4.8, pages: 144, isbn: "978-1-83947-212-7", copies: 4, cover: 6, desc: "A collection moving between the poet's two homes, one by the sea and one in the mountains." },
    { id: 13, title: "Midnight Arithmetic", author: "Elias Brandt",    genre: "Science",   year: 2020, rating: 4.4, pages: 336, isbn: "978-1-83947-213-4", copies: 3, cover: 2, desc: "The strange late-night world of the mathematicians who solve problems in their sleep." },
    { id: 14, title: "The Cartographer's Daughter", author: "Leila Fontaine", genre: "Fiction", year: 2024, rating: 4.7, pages: 388, isbn: "978-1-83947-214-1", copies: 3, cover: 1, desc: "She inherited her father's maps. Then she noticed the countries on them do not exist. Yet." },
    { id: 15, title: "Bread & Circuses",    author: "Marco Antonelli", genre: "History",   year: 2016, rating: 4.2, pages: 512, isbn: "978-1-83947-215-8", copies: 2, cover: 3, desc: "Daily life in imperial Rome, reconstructed from bakery ledgers, graffiti, and arena ticket stubs." },
    { id: 16, title: "The Ember Court",     author: "Yara Chen",       genre: "Fantasy",   year: 2023, rating: 4.8, pages: 445, isbn: "978-1-83947-216-5", copies: 4, cover: 4, desc: "The final trial of the Ember Court begins at dusk, and the youngest judge in its history is hiding a spark of her own." },
    { id: 17, title: "Notes from the Bench", author: "Justice H. Okafor", genre: "Biography", year: 2018, rating: 4.6, pages: 290, isbn: "978-1-83947-217-2", copies: 2, cover: 5, desc: "Forty years of landmark cases, quiet dissents, and the handwritten notes that never made the official record." },
    { id: 18, title: "Field Guide to Rain", author: "Tomas Kivi",      genre: "Poetry",    year: 2022, rating: 4.7, pages: 156, isbn: "978-1-83947-218-9", copies: 3, cover: 6, desc: "Fifty-two kinds of rain, one poem each, written across four years of weather." }
  ];

  // Seed members and loans so the dashboard has life before anyone signs up.
  function seedState(now) {
    const day = 24 * 60 * 60 * 1000;
    const members = [
      { id: "m-dana",  name: "Dana Kim",     email: "dana@example.com",  demo: true, createdAt: now - 90 * day },
      { id: "m-omar",  name: "Omar Reyes",   email: "omar@example.com",  demo: true, createdAt: now - 75 * day },
      { id: "m-priya", name: "Priya Nair",   email: "priya@example.com", demo: true, createdAt: now - 60 * day },
      { id: "m-cal",   name: "Callum Doyle", email: "cal@example.com",   demo: true, createdAt: now - 30 * day }
    ];
    const loans = [
      { id: "l-1", bookId: 1, userId: "m-dana",  borrowedAt: now - 4 * day,  dueAt: now + 10 * day, returnedAt: null },
      { id: "l-2", bookId: 2, userId: "m-omar",  borrowedAt: now - 19 * day, dueAt: now - 5 * day,  returnedAt: null },
      { id: "l-3", bookId: 3, userId: "m-priya", borrowedAt: now - 2 * day,  dueAt: now + 12 * day, returnedAt: null },
      { id: "l-4", bookId: 5, userId: "m-cal",   borrowedAt: now - 15 * day, dueAt: now - 1 * day,  returnedAt: null },
      { id: "l-5", bookId: 7, userId: "m-dana",  borrowedAt: now - 40 * day, dueAt: now - 26 * day, returnedAt: now - 27 * day }
    ];
    const events = [
      { at: now - 2 * day,  text: "Priya Nair borrowed Empires of Sand" },
      { at: now - 4 * day,  text: "Dana Kim borrowed The Silent Orchard" },
      { at: now - 5 * day,  text: "Atoms & Ashes marked overdue" },
      { at: now - 27 * day, text: "Dana Kim returned Harbor Lights" }
    ];
    return { books: SEED_BOOKS, users: members, loans, events, session: null };
  }

  function load() {
    try {
      const raw = localStorage.getItem(KEY);
      if (raw) {
        const state = JSON.parse(raw);
        if (state && Array.isArray(state.books) && state.books.length) return state;
      }
    } catch (e) { /* corrupted storage falls through to reseed */ }
    const fresh = seedState(Date.now());
    save(fresh);
    return fresh;
  }

  function save(state) {
    localStorage.setItem(KEY, JSON.stringify(state));
  }

  let state = load();

  function uid(prefix) {
    return prefix + "-" + Math.random().toString(36).slice(2, 10);
  }

  function activeLoans(bookId) {
    return state.loans.filter((l) => l.bookId === bookId && !l.returnedAt);
  }

  function availableCopies(bookId) {
    const book = state.books.find((b) => b.id === bookId);
    if (!book) return 0;
    return book.copies - activeLoans(bookId).length;
  }

  function logEvent(text) {
    state.events.unshift({ at: Date.now(), text });
    state.events = state.events.slice(0, 30);
  }

  const LibDB = {
    LOAN_DAYS,

    getBooks() { return state.books.slice(); },

    getBook(id) { return state.books.find((b) => b.id === Number(id)) || null; },

    genres() {
      return Array.from(new Set(state.books.map((b) => b.genre)));
    },

    availableCopies,

    isAvailable(bookId) { return availableCopies(bookId) > 0; },

    searchBooks(query, opts) {
      const q = (query || "").trim().toLowerCase();
      const o = opts || {};
      return state.books.filter((b) => {
        if (q && !(b.title.toLowerCase().includes(q) || b.author.toLowerCase().includes(q) || b.isbn.includes(q))) return false;
        if (o.genres && o.genres.length && !o.genres.includes(b.genre)) return false;
        const avail = availableCopies(b.id) > 0;
        if (o.availability === "available" && !avail) return false;
        if (o.availability === "borrowed" && avail) return false;
        if (o.minRating && b.rating < o.minRating) return false;
        return true;
      });
    },

    // ----- users -----
    getUsers() { return state.users.slice(); },
    findUserByEmail(email) {
      const e = (email || "").trim().toLowerCase();
      return state.users.find((u) => u.email.toLowerCase() === e) || null;
    },
    getUser(id) { return state.users.find((u) => u.id === id) || null; },
    addUser(user) {
      user.id = uid("u");
      user.createdAt = Date.now();
      state.users.push(user);
      logEvent("New member " + user.name + " registered");
      save(state);
      return user;
    },

    // ----- session -----
    getSession() { return state.session; },
    setSession(userId) {
      state.session = { userId, token: uid("s"), createdAt: Date.now() };
      save(state);
    },
    clearSession() {
      state.session = null;
      save(state);
    },
    currentUser() {
      return state.session ? this.getUser(state.session.userId) : null;
    },

    // ----- loans -----
    getLoans() { return state.loans.slice(); },
    loansForUser(userId) {
      return state.loans.filter((l) => l.userId === userId && !l.returnedAt);
    },
    userHasBook(userId, bookId) {
      return state.loans.some((l) => l.userId === userId && l.bookId === Number(bookId) && !l.returnedAt);
    },
    borrow(bookId, userId) {
      const book = this.getBook(bookId);
      const user = this.getUser(userId);
      if (!book || !user) return { ok: false, error: "Book or member not found." };
      if (this.userHasBook(userId, bookId)) return { ok: false, error: "You already have this book on loan." };
      if (availableCopies(book.id) <= 0) return { ok: false, error: "No copies available right now." };
      const now = Date.now();
      const loan = { id: uid("l"), bookId: book.id, userId, borrowedAt: now, dueAt: now + LOAN_DAYS * 24 * 60 * 60 * 1000, returnedAt: null };
      state.loans.unshift(loan);
      logEvent(user.name + " borrowed " + book.title);
      save(state);
      return { ok: true, loan };
    },
    returnLoan(loanId) {
      const loan = state.loans.find((l) => l.id === loanId);
      if (!loan || loan.returnedAt) return { ok: false, error: "Loan not found." };
      loan.returnedAt = Date.now();
      const book = this.getBook(loan.bookId);
      const user = this.getUser(loan.userId);
      logEvent((user ? user.name : "A member") + " returned " + (book ? book.title : "a book"));
      save(state);
      return { ok: true };
    },

    // ----- derived -----
    stats() {
      const now = Date.now();
      const active = state.loans.filter((l) => !l.returnedAt);
      return {
        titles: state.books.length,
        copies: state.books.reduce((sum, b) => sum + b.copies, 0),
        members: state.users.length,
        activeLoans: active.length,
        overdue: active.filter((l) => l.dueAt < now).length
      };
    },
    recentLoans(limit) {
      return state.loans
        .slice()
        .sort((a, b) => b.borrowedAt - a.borrowedAt)
        .slice(0, limit || 6);
    },
    recentEvents(limit) {
      return state.events.slice(0, limit || 6);
    },
    topGenres() {
      const counts = {};
      state.loans.forEach((l) => {
        const book = this.getBook(l.bookId);
        if (book) counts[book.genre] = (counts[book.genre] || 0) + 1;
      });
      const total = Object.values(counts).reduce((a, b) => a + b, 0) || 1;
      return Object.entries(counts)
        .map(([genre, n]) => ({ genre, pct: Math.round((n / total) * 100) }))
        .sort((a, b) => b.pct - a.pct)
        .slice(0, 5);
    },

    reset() {
      state = seedState(Date.now());
      save(state);
    }
  };

  window.LibDB = LibDB;
})();
