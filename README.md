# Student Management System

A web-based Student Management System built with **ASP.NET Core MVC**, **Entity Framework Core**, and **MySQL**.

The project was created to practice backend development concepts including MVC architecture, database integration, CRUD operations, dependency injection, and server-side validation.

## Features

- View all students
- Add new students
- Edit existing student information
- Delete students
- Store student data in a MySQL database
- Server-side validation
- MVC architecture
- Database operations using Entity Framework Core

## Technologies Used

- C#
- ASP.NET Core MVC
- Entity Framework Core
- MySQL
- Razor Views
- HTML / CSS
- Bootstrap

## Project Structure

- `Controllers/` — Handles HTTP requests and application flow
- `Models/` — Contains the Student model and application data models
- `Views/` — Contains Razor views for the user interface
- `Data/` — Contains the Entity Framework database context
- `Migrations/` — Contains Entity Framework database migrations
- `wwwroot/` — Contains static files such as CSS, JavaScript, and libraries
- `Program.cs` — Configures application services and the HTTP request pipeline

## Concepts Practiced

### MVC Architecture

The application separates responsibilities into Models, Views, and Controllers.

### CRUD Operations

The system supports:

- Create
- Read
- Update
- Delete

student records.

### Entity Framework Core

Entity Framework Core is used to communicate with the MySQL database and manage data using C# objects.

### Dependency Injection

ASP.NET Core's built-in Dependency Injection system is used to provide the database context to controllers.

Example:

```csharp
public StudentController(ApplicationDbContext context)
{
    _context = context;
}

The controller depends on ApplicationDbContext, and ASP.NET Core provides the required instance automatically.
Database Migrations
Entity Framework Core migrations are used to create and update the database schema based on the application's models.
Purpose
This project was built as part of my backend development training with C# and ASP.NET Core, focusing on understanding how a complete MVC application communicates with a relational database.

