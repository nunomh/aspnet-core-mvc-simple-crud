# ASP.NET Core MVC Course for Beginners (.NET 9)

Based on the Code A Future youtube video https://www.youtube.com/watch?v=RWXKysImabs

## Installation and running

- Install .NET 9 SDK
- appsettings.json must be created with ConnectionStrings to connect to the database

### NuGet Packages

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.EntityFrameworkCore.SqlServer

## MVC (MODEL - VIEW - CONTROLLER)

MVC stands for Model-View-Controller. It is a design pattern used in software development to separate an application into three interconnected components. This separation of concerns makes it easier to maintain and update the application.

- Model - This is the data model (information) of the application. It represents the data and the business logic that operates on that data. Ex: data from a book collection.
- View - This is the user interface (UI) of the application. It is responsible for displaying the data to the user. Ex: a list of books.
- Controller - This is the glue that holds the application together. It receives input from the user, interacts with the model, and updates the view accordingly. Ex: a button that adds a new book to the list.

### MVC Architecture

- Program.cs - entry point for the application

## Razor

Razor is a templating engine used in ASP.NET Core used to embed c# code into html. The @ symbol is used in Razor pages

## Entity Framework Core (EF Core)

Entity Framework (EF) Core is a lightweight, extensible, open source and cross-platform version of the popular Entity Framework data access technology. EF Core can serve as an object-relational mapper (O/RM), which: Enables .NET developers to work with a database using .NET objects

Two main approaches:

- Code First - Allows to generate the database from the c# classes
- Database First - The code is generated based on the existing database

To create the connection, it's required to create the context. (Data/MyAppContext.cs)

### Database migration

Code > Database
To create the migration file, in NuGet Package Manager Console run `Add-Migration "Initial Migration"`
To apply the migration, run `Update-Database`. It will create the tables in it.
For every change in the model, run `Add-Migration "Change"` and then `Update-Database`

Database > Code
If the desired is to migrate from the database to the code, run `Scaffold-DbContext "Data Source=xxxxxx;Initial Catalog=SSL_DEV;Persist Security Info=True;User ID=sa;Password=xxxxxx;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -Output Models -DataAnnotation`
