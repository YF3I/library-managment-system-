# Athenaeum: Library Management System (UI Design)

A clean, modern **front-end web app** for a library management system, built as static HTML/CSS/JS pages that run entirely in the browser. Create an account, sign in, search and filter the catalog, borrow and return books, and watch the dashboard update live. Data persists in `localStorage`; passwords are hashed with PBKDF2 (Web Crypto), never stored in plaintext. There is no server: each visitor gets their own private copy of the library data.

## Preview

| Page | Description |
|---|---|
| [`index.html`](index.html) | Landing page: hero search, stats, featured books, features |
| [`login.html`](login.html) | Sign in / create account, split-screen auth layout |
| [`catalog.html`](catalog.html) | Book catalog with filters (genre, availability, format, rating) |
| [`book-detail.html`](book-detail.html) | Single book page: overview, details, reviews tabs |
| [`dashboard.html`](dashboard.html) | Librarian dashboard: stats, recent loans, activity feed |

## Design system

- **Palette:** paper, ink, and a single stamp-red accent (with a quiet moss green for secondary tags), instead of a generic dark-navy-and-gold "AI-premium" look.
- **Type:** [Fraunces](https://fonts.google.com/specimen/Fraunces) for headings (editorial, book-like), [Inter](https://fonts.google.com/specimen/Inter) for body/UI text.
- **Icons:** one consistent inline SVG stroke set, no emoji, no mismatched icon styles.
- **Motion:** `ease-out` entrances, durations under 300ms, `scale(0.97)` active states on buttons, staggered card entrances (30–80ms apart), and `prefers-reduced-motion` support. Only `transform`/`opacity` are animated.
- **Layout:** an asymmetric hero and a bento-style feature grid (one lead card plus two supporting cards) instead of three equal centered cards.
- All shared styles live in [`assets/css/styles.css`](assets/css/styles.css). Vanilla JS, no frameworks: [`main.js`](assets/js/main.js) handles UI interactions, [`db.js`](assets/js/db.js) is the localStorage data layer, [`auth.js`](assets/js/auth.js) handles accounts and sessions, and [`app.js`](assets/js/app.js) wires each page.

## Running locally

No build step or dependencies required, it's static HTML/CSS/JS.

```bash
# from this folder
python -m http.server 4173
# then open http://localhost:4173
```

Or just open `index.html` directly in a browser.

## Project structure

```
library-management-system/
├── index.html
├── login.html
├── catalog.html
├── book-detail.html
├── dashboard.html
├── assets/
│   ├── css/styles.css
│   ├── js/main.js
│   └── img/
└── README.md
```

## Status

Working front-end demo. The natural next step is swapping the localStorage layer (`assets/js/db.js`) for a real backend API so data is shared between visitors.
