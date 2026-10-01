# GENTLEMAN — Java Swing POS System

A Java Swing desktop application demonstrating Object-Oriented Programming concepts through a point-of-sale system for a watches and glasses shop. Developed as an academic OOP project using NetBeans GUI Builder.

---

## Overview

This project implements a complete POS workflow: user authentication (login/sign-up), main dashboard navigation, product catalog with quantity selection, shopping cart with real-time totals, payment processing with balance calculation, and receipt printing. Built to practice and demonstrate core OOP principles in a practical desktop application context.

---

## Features

### Authentication Flow
- **Login (login.java)** — Email/password fields with validation; hardcoded credentials (`GENTLEMAN` / `123`); navigates to `dashboardmain` on success
- **Sign-up (signup.java)** — Name, email, password, confirm password fields; validation for all required fields; navigates back to login on success
- **Session Navigation** — Proper frame disposal and new instance creation between screens

### Main Dashboard (dashboardmain.java)
- Side navigation panel (gold theme) with three actions:
  - **PRODUCT** — Opens product catalog (`dashboard`)
  - **DASHBOARD** — Disabled (placeholder for future expansion)
  - **LOG OUT** — Returns to login screen
- Background image display

### Product Catalog / POS (dashboard.java)
- **11 Product Buttons** with images — Glasses, sunglasses, watches (each with unique ID, name, price)
- **Quantity Counters** — Label-based counters (q1–q11) increment per click
- **Shopping Cart (JTable)** — Columns: ID, ITEM, QUANTITY, PRICE
  - Duplicate prevention: same item updates quantity instead of new row
  - Row deletion via DELETE button
- **Real-time Total** — `cal()` method sums price column; formatted with `DecimalFormat("00.00")`
- **Payment Processing** — Cash input → `pay()` computes balance (cash - total); handles invalid input
- **Receipt Printing** — `printActionPerformed()` generates formatted receipt in JTextArea:
  - Shop header (GENTLEMAN WATCHES AND GLASSES, St. John Paul College of Davao)
  - Itemized list with quantity and price
  - Subtotal, Cash, Balance
  - Footer message
  - Sends to system print dialog (`b.print()`)
- **Navigation** — BACK button returns to `dashboardmain`

---

## Technologies Used

| Category | Technologies |
|----------|--------------|
| **Language** | Java (JDK 8+) |
| **GUI Framework** | Swing (javax.swing) |
| **Layout Manager** | AbsoluteLayout (NetBeans GUI Builder / `org.netbeans.lib.awtextra.AbsoluteLayout`) |
| **IDE** | NetBeans (primary) / VS Code |
| **Build** | Ant (`build.xml`, `nbproject/`) |
| **Key Classes** | `JFrame`, `JPanel`, `JButton`, `JTable`, `JTextArea`, `JTextField`, `JPasswordField`, `JLabel`, `JScrollPane`, `DefaultTableModel`, `Vector`, `DecimalFormat`, `JOptionPane`, `ImageIcon` |

---

## OOP Concepts Demonstrated

| Concept | Implementation Evidence |
|---------|------------------------|
| **Classes & Objects** | 5 JFrame classes (`Gentleman`, `login`, `signup`, `dashboardmain`, `dashboard`); each instantiated as objects |
| **Encapsulation** | Private fields (`user`, `pass`, `q1`–`q11`, `jTable2`, etc.) with controlled access via methods |
| **Inheritance** | All form classes extend `javax.swing.JFrame` |
| **Polymorphism** | Event handlers (`ActionListener`) — same interface, different implementations per button |
| **Abstraction** | Reusable methods hide implementation: `addtable()`, `cal()`, `pay()`, `resetQuantityLabel()` |
| **Constructors** | Each form initializes components via `initComponents()` (auto-generated) |
| **Methods** | Instance methods for cart logic, calculation, payment, receipt generation, quantity reset |
| **Event-Driven Programming** | All interactions via `ActionListener` / `ActionPerformed` callbacks |

---

## Project Structure

```
Gentleman/
├── build.xml                 # Ant build script
├── manifest.mf               # JAR manifest
├── nbproject/                # NetBeans project metadata
│   ├── build-impl.xml
│   ├── genfiles.properties
│   ├── project.properties
│   └── project.xml
└── src/
    └── gentleman/
        ├── Gentleman.java       # Entry point → launches login
        ├── login.java           # Login form + authentication
        ├── signup.java          # Sign-up form + validation
        ├── dashboardmain.java   # Main navigation dashboard
        ├── dashboard.java       # Product catalog + POS logic
        ├── *.form               # NetBeans form metadata
        └── *.png / *.jpg        # Product images & backgrounds
```

---

## Screenshots

| Login | Sign Up | Main Dashboard | Product Catalog / POS | Receipt Print |
|-------|---------|----------------|----------------------|---------------|
| [ADD SCREENSHOT] | [ADD SCREENSHOT] | [ADD SCREENSHOT] | [ADD SCREENSHOT] | [ADD SCREENSHOT] |

---

## How It Works

1. **Entry Point** — `Gentleman.main()` creates and shows `login` frame
2. **Login** — Validates credentials; on success → `dashboardmain`
3. **Main Dashboard** — User chooses PRODUCT (→ `dashboard`) or LOG OUT (→ `login`)
4. **Product Catalog** — Click product buttons → increments quantity label → `addtable()` adds/updates cart row → `cal()` updates total
5. **Cart Management** — DELETE removes selected row, resets quantity label, recalculates total
6. **Payment** — Enter cash → PAY computes balance → PRINT generates receipt → system print dialog
7. **Navigation** — BACK returns to `dashboardmain`; LOG OUT returns to `login`

---

## How to Run

### Prerequisites
- Java JDK 8 or later
- NetBeans IDE (recommended for GUI forms) **or** VS Code with Java Extension Pack
- Ant (included with NetBeans)

### Via NetBeans (Recommended)
1. Open NetBeans → **File > Open Project** → select `Gentleman` folder
2. Right-click project → **Build** (or `F11`)
3. Right-click project → **Run** (or `F6`)

### Via Command Line (Ant)
```bash
cd Gentleman
ant clean build run
```

### Via VS Code
1. Open `Gentleman` folder
2. Install **Extension Pack for Java** (Microsoft)
3. Run `Gentleman.java` main method

---

## What I Learned

- Building desktop GUIs with Swing and NetBeans GUI Builder (Matisse)
- AbsoluteLayout positioning and component grouping with panels
- JTable with DefaultTableModel for dynamic row management
- Event handling with anonymous inner classes (ActionListener)
- Form-to-form navigation with proper resource cleanup (`dispose()`)
- DecimalFormat for currency display
- JTextArea content building and system printing (`JTextComponent.print()`)
- ImageIcon loading from absolute paths and classpath resources
- Organizing multi-form applications with clear entry points
- Applying OOP principles in a GUI context (encapsulation, inheritance, method reuse)

---

## Future Improvements

- [ ] Replace hardcoded credentials with database-backed authentication
- [ ] Persist products, sales, and user data (SQLite / MySQL)
- [ ] Add product management (CRUD for admin)
- [ ] Implement sales history / reporting
- [ ] Migrate from AbsoluteLayout to layout managers (GridBagLayout, MigLayout) for responsiveness
- [ ] Separate business logic from UI (MVC pattern)
- [ ] Add input sanitization and validation
- [ ] Unit tests for calculation and cart logic
- [ ] Externalize product data (JSON/config file)
- [ ] Improve accessibility (labels, focus order, contrast)

---

## Documentation

Project documentation and certificates:  
[Facebook Documentation](https://www.facebook.com/share/v/1JpdU77gPM/)

---

## Author

**Sir Angelo Salizon**  
Fresh BSIT Graduate • Aspiring Software Engineer  

GitHub: [https://github.com/angeloasalizon-ui](https://github.com/angeloasalizon-ui)  
Email: angelo_asalizon@sjp2cd.edu.ph

---

*Academic OOP Project — St. John Paul II College of Davao*