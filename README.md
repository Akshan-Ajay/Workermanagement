# Worker Management System

A C# Windows Forms desktop application designed to manage employee records, calculate totals, and simplify workforce administration.

## Features

- **Employee Data Management:** Add, update, delete, and clear employee entries.
- **Tracked Details:** Manage Employee ID, Name, Email, and Salary information.
- **Employee Counter:** Live display tracking the total number of registered employees.
- **User Interface:** Simple WinForms layout with dedicated input fields and action buttons.
- **Database Integration:** Stores employee information using a local SQL Server database.

## Prerequisites

- **Operating System:** Windows 10 / 11
- **Development Environment:** [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload installed.
- **Framework:** .NET Framework / .NET Core (supports .NET 9 SDK)
- **Database:** Local Database / SQL Server Express (`.mdf` attached in solution)

## Getting Started

### 1. Clone the Repository

    git clone https://github.com/Akshan-Ajay/Workermanagement.git

### 2. Open the Project

1. Launch Visual Studio 2022.
2. Select **Open a project or solution**.
3. Open `WorkerManagement.sln`.

### 3. Run the Application

1. Select the **Debug** or **Release** configuration.
2. Click **Start** or press **F5** in Visual Studio.
3. The application will build and launch.

## Project Structure

    WorkerManagement/
    │
    ├── WorkerManagement.sln
    │
    └── WorkerManagement/
        ├── Form1.cs
        ├── Form1.Designer.cs
        ├── Form1.resx
        ├── Database1.mdf
        ├── App.config
        └── Program.cs

## File Descriptions

| File | Description |
|---|---|
| `WorkerManagement.sln` | Visual Studio Solution File |
| `Form1.cs` | Main interface logic |
| `Form1.Designer.cs` | Form layout and UI configuration |
| `Form1.resx` | UI resources |
| `Database1.mdf` | Local SQL Server database file |
| `App.config` | Application configuration and database settings |
| `Program.cs` | Main entry point of the application |

## Functionalities

### Add Employee

Allows users to add employee information including:

- Employee ID
- Name
- Email
- Salary

### Update Employee

Allows users to modify existing employee information.

### Delete Employee

Allows users to remove employee records from the system.

### Clear

Clears the input fields so users can enter new employee information.

### Employee Counter

Displays the total number of registered employees and updates when employee records are added or deleted.

## Technologies Used

- **C#**
- **Windows Forms (WinForms)**
- **.NET**
- **SQL Server / LocalDB**
- **Visual Studio 2022**

## Database

The application uses a local SQL Server database to store employee information.

The database file included in the solution is:

`Database1.mdf`

The database configuration can be found in:

`App.config`

## Application Purpose

The Worker Management System is a desktop-based employee management application developed using C# and Windows Forms.

The application demonstrates:

- Object-Oriented Programming
- Windows Forms development
- Event-driven programming
- User interface design
- Database integration
- CRUD operations
- Employee record management

## Future Improvements

- Employee search and filtering
- Department management
- Employee attendance tracking
- Salary calculation and reporting
- Export data to Excel or CSV
- User authentication
- Role-based access control
- Employee dashboard
- Improved database architecture
- Backup and restore functionality

## Repository

[Worker Management System](https://github.com/Akshan-Ajay/Workermanagement)
