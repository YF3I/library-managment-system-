# 📚 MAQ Online Library

A desktop **Windows Forms (C#)** application for managing a small library — borrowing books, tracking members, and administering the catalog — built on **.NET Framework 4.7.2** with a **SQL Server LocalDB** backend.

> 🎨 **Web demo:** this repo also includes a working web version of the system (sign up, log in, browse, borrow and return books) in the [`docs/`](docs/) folder — try the [live demo](https://yf3i.github.io/library-managment-system-/). It runs fully in the browser: data is saved in localStorage and passwords are PBKDF2-hashed, no server required.

---

## Overview

MAQ Online Library simulates a real-world library system with three distinct user roles, each with its own login and dashboard:

| Role | What they can do |
|---|---|
| **Borrower** | Sign up / log in, browse books by category, add books to a cart, and check out through a mock payment page |
| **Librarian** | Log in, search the catalog, and insert/delete book records (title, category, author, price, quantity) |
| **Manager** | Log in and manage librarian accounts (add, delete, edit, and page through records) |

The app was built with WinForms + ADO.NET **TableAdapters** (typed DataSets), so all CRUD operations are wired directly to SQL Server tables through the Visual Studio designer.

---

## Features

- 🔐 **Role-based login** — a single Login screen routes users to the Borrower or Librarian dashboard based on credentials and selected role; a separate Manager login exists via the menu bar
- 📝 **Borrower sign-up** with validation (username, password + confirmation, email, phone number)
- 🗂️ **Book browsing by category** — Academics, Fiction, Non-Fiction, Poetry, Drama, and Literature, each with its own catalog view
- 🛒 **Shopping-cart style borrowing flow** — add selected titles to a list, choose a format (Hardcopy / Download / Flash Drive), and pay
- 💳 **Payment screen** with basic form validation for card number, expiry, CVV, and cardholder name
- 🔎 **Book search** by name for librarians
- ➕➖ **Full book CRUD** for librarians (insert/delete titles, price, quantity, author, category)
- 👥 **Librarian account management** for managers (add/insert/delete, plus first/previous/next/last record navigation and save)
- ℹ️ **About Us** dialog accessible from the main menu

---

## Tech Stack

- **Language:** C#
- **UI Framework:** Windows Forms (.NET Framework 4.7.2)
- **Data Access:** ADO.NET Typed DataSets & TableAdapters
- **Database:** SQL Server LocalDB (`MSSQLLocalDB`) — three attached `.mdf` databases:
  - `MAQDataBase.mdf` — borrowers & user accounts
  - `ManagerDataBase.mdf` — librarian records managed by the manager
  - `Books.mdf` — book catalog
- **IDE:** Visual Studio (2019/2022) with the Windows Forms Designer

---

## Project Structure

```
MAQ Online Library/
├── MAQ Online Library.sln          # Visual Studio solution
└── MAQ Online Library/
    ├── Form1.cs / .Designer.cs     # Login & Sign-up screen (entry point)
    ├── Librarian.cs / .Designer.cs # Librarian dashboard (search, insert, delete books)
    ├── Manager.cs / .Designer.cs   # Manager login
    ├── ManagerControlPage.cs       # Manager dashboard (manage librarians)
    ├── AboutUs.cs                  # About dialog
    ├── Program.cs                  # Application entry point
    ├── Resources/
    │   ├── Borrowerrr.cs           # Borrower dashboard (browse & borrow books)
    │   ├── PaymentPage.cs          # Checkout / payment form
    │   └── *.jpg / *.png           # Book cover art & UI images
    ├── *.xsd / *.Designer.cs       # Typed DataSets (BooksDataSet, MAQDataBaseDataSet, ManagerDataBaseDataSet, etc.)
    ├── *.mdf / *.ldf               # LocalDB database files
    └── App.config                  # Connection strings
```

---

## Getting Started

### Prerequisites
- Windows OS
- Visual Studio 2019 or later (with **.NET desktop development** workload)
- **SQL Server Express LocalDB** (bundled with Visual Studio)

### Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/YF3I/library-managment-system-.git
   ```
2. Open `MAQ Online Library.sln` in Visual Studio.
3. Verify the three `.mdf` database files are present under the project directory (`MAQDataBase.mdf`, `ManagerDataBase.mdf`, `Books.mdf`). They attach automatically via LocalDB using the connection strings in `App.config`.
4. Build the solution (**Build → Build Solution**).
5. Run the app (**F5**) — it launches on the **Login** screen.

### Usage
- **Borrower:** Sign up for an account or log in, select "Borrower", browse categories, add books, choose a format, and proceed to payment.
- **Librarian:** Log in with librarian credentials and select "Librarian" to search, add, or remove books.
- **Manager:** From the menu bar, choose **Login as Manager**, sign in, and manage librarian accounts.

---

## Notes

This project was built as an academic/learning exercise to practice WinForms UI design and ADO.NET database binding. Known limitations worth being aware of if you plan to extend it:

- Passwords are stored and compared as plain text — not suitable for production use
- The payment form does not process real transactions (validation only)
- Some UI logic (e.g., category switching, cart handling) is done with manual index checks rather than data binding

Contributions and refactors (parameterized queries, password hashing, MVC-style separation) are welcome.

---

## License

Add your preferred license here (e.g., MIT).
