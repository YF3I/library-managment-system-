# 📖 Athenaeum — Library Management System (UI Design)

A clean, modern **front-end design** for a library management system — built as static HTML/CSS/JS pages. This is a **visual design mockup**: no backend, no database, no real authentication. All data on the pages is placeholder content meant to showcase the UI/UX.

## Preview

| Page | Description |
|---|---|
| [`index.html`](index.html) | Landing page — hero search, stats, featured books, features |
| [`login.html`](login.html) | Sign in / create account, split-screen auth layout |
| [`catalog.html`](catalog.html) | Book catalog with filters (genre, availability, format, rating) |
| [`book-detail.html`](book-detail.html) | Single book page — overview, details, reviews tabs |
| [`dashboard.html`](dashboard.html) | Librarian dashboard — stats, recent loans, activity feed |

## Design system

- **Palette:** deep navy + warm amber + soft teal, on a cream background — evokes a reading room rather than a generic admin panel.
- **Type:** [Poppins](https://fonts.google.com/specimen/Poppins) for headings, [Inter](https://fonts.google.com/specimen/Inter) for body text.
- **Layout:** responsive CSS Grid/Flexbox, mobile breakpoints at 960px and 640px.
- All shared styles live in [`assets/css/styles.css`](assets/css/styles.css); interactions (tabs, filter chips, mobile nav) are handled by a small vanilla JS file in [`assets/js/main.js`](assets/js/main.js) — UI-only, no data logic.

## Running locally

No build step or dependencies required — it's static HTML/CSS/JS.

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

🎨 Design phase — pages are static mockups. Wiring up a real backend (auth, database, borrow/return logic) is a future step.
