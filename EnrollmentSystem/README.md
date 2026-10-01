# Enrollment System

A C# Windows Forms enrollment system developed as an academic project, featuring role-based interfaces for administrative, student, and faculty functions.

---

## Overview

This desktop application demonstrates C# Windows Forms development with a multi-role authentication system. Built as a BSIT academic project, it showcases event-driven programming, form navigation, data presentation with ListView and DataGridView, and basic CRUD operations for student record management across multiple academic programs.

**Important:** All data is stored in-memory only. No database is used. Data does not persist across application restarts.

---

## Features

### Authentication & Roles
- **Student Login** — Access to course-specific enrollment lists (username: `student`, password: `123`)
- **Admin Login** — Full administrative dashboard with student management across 8 courses (username: `admin`, password: `123`)
- **Faculty Login** — Subject scheduling view (username: `faculty`, password: `123`)
- **Sign-up Panel** — Account creation with input validation (required fields, password matching) — **in-memory only, no persistence**

### Student Dashboard (Form2)
- Tabbed interface for 8 academic programs:
  - BS Information Technology (IT)
  - BS Criminology (CRIM)
  - BS Education (EDUC)
  - BS Nursing (NURSING)
  - BS Engineering (ENGINEER)
  - BS Tourism (TOURISM)
  - BS Business Administration (BA)
  - BS Hospitality Management (HK)
- ListView display with columns: Firstname, Middlename, Lastname, Age, ID Number, Gender
- Pre-populated sample data (1 student per course) — hardcoded in `Form2_Load`
- Navigation via buttons and picture boxes
- Logout returns to login form

### Faculty Dashboard (Form3)
- DataGridView showing subject schedule with columns: Code, Subject Name, Section, Schedule, Units
- 8 pre-loaded subjects (ICT101–ICT108) across BSIT-1A, BSIT-1B, BSIT-1C sections — hardcoded in `Form3_Load`
- Auto-sized columns, full row selection, no user row addition

### Admin Dashboard (Form4)
- Course selection panel (8 programs)
- Per-course student management with full CRUD:
  - **Add** — Enable input fields, create new ListViewItem
  - **Update** — Modify selected record in ListView
  - **Delete** — Remove selected record with confirmation
- Input fields: Firstname, Middlename, Lastname, Age, ID Number, Gender (ComboBox)
- Button state management (enable/disable based on action)
- **All operations in-memory only**

---

## Technologies Used

| Category | Technology |
|----------|------------|
| **Language** | C# |
| **Framework** | .NET (Windows Forms) |
| **IDE** | Visual Studio [NEEDS VERIFICATION — project targets `net10.0-windows`] |
| **Target Framework** | `net10.0-windows` |
| **UI Components** | ListView, DataGridView, TextBox, ComboBox, Button, Panel, PictureBox |
| **Database** | **None** — all data in-memory |

---

## Screenshots

| Login | Student Dashboard | Admin Dashboard | Faculty Dashboard |
|-------|-------------------|-----------------|-------------------|
| [ADD SCREENSHOT] | [ADD SCREENSHOT] | [ADD SCREENSHOT] | [ADD SCREENSHOT] |

---

## How It Works

1. **Entry Point** — `Program.cs` initializes the application and launches `Form1` (Login)
2. **Login (Form1)** — Validates credentials against hardcoded values; routes to appropriate dashboard form
3. **Form Navigation** — Each form hides the previous and shows the next; logout creates new `Form1` instance
4. **Data Display** — ListView (Details view) for student records; DataGridView for subject schedules
5. **CRUD Operations** — Admin dashboard implements Add/Update/Delete per course with ListViewItems
6. **Input Validation** — Sign-up checks for empty fields and password match

---

## How to Run

### Prerequisites
- Visual Studio 2022 or later with **.NET Desktop Development** workload
- .NET 10.0 SDK (or modify `.csproj` to target installed version) [NEEDS VERIFICATION]

### Steps
1. Clone the repository:
   ```bash
   git clone [ADD LINK]
   ```
2. Open `SALIZONPOGI.slnx` (or `SALIZONPOGI.csproj`) in Visual Studio
3. Restore NuGet packages if prompted
4. Press `F5` or click **Start** to run

### Default Credentials
| Role | Username | Password |
|------|----------|----------|
| Student | `student` | `123` |
| Admin | `admin` | `123` |
| Faculty | `faculty` | `123` |

---

## What I Learned

- Windows Forms event-driven architecture and form lifecycle (`Show()`, `Hide()`, `Close()`, `Dispose()`)
- Multi-form application design with role-based navigation
- ListView and DataGridView configuration (columns, view modes, selection behavior)
- Runtime control manipulation (enable/disable, visibility, dynamic column creation)
- Basic input validation and user feedback via MessageBox
- Project structure in Visual Studio (`.slnx`, `.csproj`, `Program.cs`, designer files)

---

## Future Improvements

- [ ] Replace hardcoded credentials with database authentication (SQL Server / SQLite)
- [ ] Persist student records to a database instead of in-memory ListViewItems
- [ ] Add search/filter functionality for student lists
- [ ] Implement data validation (age range, ID format, email format)
- [ ] Add course/subject management for admin (currently only student management)
- [ ] Improve UI/UX with consistent styling, responsive layouts
- [ ] Add error handling and logging
- [ ] Unit tests for business logic
- [ ] Implement Form5 functionality (currently empty/unused)

---

## Author

**Sir Angelo Salizon**  
Fresh BSIT Graduate • Aspiring Software Engineer  

GitHub: [https://github.com/angeloasalizon-ui](https://github.com/angeloasalizon-ui)  
Email: angelo_asalizon@sjp2cd.edu.ph

---

*Academic project — St. John Paul II College of Davao*