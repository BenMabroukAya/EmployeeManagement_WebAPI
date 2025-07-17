
# 👩‍💼 Employee Management WebAPI (MVC)

A comprehensive Employee Management System built using **ASP.NET Core MVC**, featuring RESTful WebAPI endpoints for managing employees and departments.

![GitHub repo size](https://img.shields.io/github/repo-size/BenMabroukAya/EmployeeManagement_WebAPI)
![GitHub last commit](https://img.shields.io/github/last-commit/BenMabroukAya/EmployeeManagement_WebAPI)

---

## 🚀 Features

- ✅ ASP.NET Core MVC architecture
- 🧩 RESTful WebAPI with CRUD operations
- 💼 Employee & Department management
- 🗃 Entity Framework Core (code-first)
- 🔄 Dependency Injection for clean architecture
- 🔍 LINQ for advanced data querying
- 📑 Swagger/OpenAPI documentation

---

## 🛠 Technologies Used

- **Framework**: ASP.NET Core MVC (WebAPI)
- **ORM**: Entity Framework Core
- **Language**: C#
- **Database**: SQL Server
- **API Documentation**: Swagger / OpenAPI
- **IDE**: Visual Studio 2022
- **.NET Version**: .NET 8.0 SDK

---

## 📁 Project Structure

```

EmployeeManagement/
├── EmployeeManagement.Models/
│   ├── Models/                 # Data Models and Entities
│   │   ├── Department.cs
│   │   ├── Employee.cs
│   │   └── Gender.cs
│   ├── bin/
│   │   ├── Debug/net8.0/
│   │   │   ├── EmployeeManagement.Models.deps.json
│   │   │   ├── EmployeeManagement.Models.dll
│   │   │   └── EmployeeManagement.Models.pdb
│   │   └── Release/net8.0/
│   │       ├── publish/
│   │       ├── EmployeeManagement.Models.deps.json
│   │       ├── EmployeeManagement.Models.dll
│   │       └── EmployeeManagement.Models.pdb
│   ├── obj/                    # Temporary files
│   ├── Class1.cs               # Example class file
│   └── EmployeeManagement.Models.csproj
│
├── EmployeeManagement.Web/
│   ├── Layout/                 # Razor Layout Pages
│   ├── Pages/                  # Web Pages
│   ├── Properties/             # Project Settings
│   ├── Services/               # Services and Business Logic
│   ├── bin/                    # Build outputs
│   │   └── Debug/net8.0/
│   ├── obj/                    # Temporary files
│   ├── wwwroot/                # Static Files (CSS, JS, Images)
│   ├── App.razor               # Root Razor Component
│   ├── EmployeeManagement.Web.csproj
│   ├── Program.cs              # Application Entry Point
│   └── \_Imports.razor          # Razor Imports
│
└── WebApiEmployee/             # Web API Layer
├── Controllers/            # API Controllers
├── Migrations/             # EF Core Migrations
├── Models/                 # API Models and Data Entities
├── Properties/             # Project Properties
├── bin/                    # Build Outputs
├── obj/                    # Temporary files
├── WeatherForecast.cs      # Example class
├── WebApiEmployee.csproj   # Web API Project File
├── WebApiEmployee.csproj.user
├── WebApiEmployee.http     # HTTP requests file for testing
├── appsettings.Development.json
├── appsettings.json
└── README.md

````

---

## 🔧 Getting Started

### ✅ Prerequisites

Make sure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (with ASP.NET and EF Core workloads)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

---

### 📦 Installation & Setup

1. **Clone the Repository**
   ```bash
   git clone https://github.com/BenMabroukAya/EmployeeManagement_WebAPI.git

2. **Open the Solution**

   * Open the `.sln` file in **Visual Studio 2022**

3. **Configure the Database**

   * Edit your `appsettings.json` with your local SQL Server connection string:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=EmployeeDB;Trusted_Connection=True;"
   }
   ```

4. **Run EF Migrations**

   ```bash
   dotnet ef database update
   ```

5. **Run the Application**

   * Press `F5` or run via terminal:

   ```bash
   dotnet run
   ```

---

## 📘 API Documentation (Swagger)

Swagger UI is enabled by default. Once the app is running, access:

👉 `https://localhost:{port}/swagger`

### 🔑 Sample Endpoints

#### 🔹 Employees

* `GET /api/employees` – List all employees
* `GET /api/employees/{id}` – Get employee by ID
* `POST /api/employees` – Create new employee
* `PUT /api/employees/{id}` – Update employee
* `DELETE /api/employees/{id}` – Delete employee

#### 🔹 Departments

* `GET /api/departments` – List all departments
* *(Extend endpoints as needed)*

---

## 🧠 Development Approach

* MVC and WebAPI pattern for maintainability
* Repository & Service layers for separation of concerns
* Dependency Injection for testable and clean code
* LINQ for readable and expressive data queries
* Swagger for quick API testing and documentation

---

## 🤝 Contributing

Want to contribute? Here's how:

1. Fork the repo
2. Create a new branch: `git checkout -b feature/myFeature`
3. Commit your changes: `git commit -m 'Add feature'`
4. Push to your branch: `git push origin feature/myFeature`
5. Open a Pull Request

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 👩‍💻 Author

**Aya Ben Mabrouk**
🔗 [GitHub](https://github.com/BenMabroukAya)
🔗 [LinkedIn](https://www.linkedin.com/in/aya-ben-mabrouk)


