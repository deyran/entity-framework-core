# Getting Started with Entity Framework Core [1 of 5]

## First step

1. Create a console app called "ContosoPizza"

```
dotnet new console --framework net8.0 --use-program-main
```

* Understanding the .Net CLI (Command Line Interface) above

    1. **dotnet**: This command-line is used to execute various commands for developing, building, and managing .Net applications.
    2. **new console**: Is used to create a new console application.
    3. **--framework net8.0**: This option is targeting the framework for the new project. In this case .Net 8.0 framework

2. Installing the **Entity Framework Core (EF Core)** package:

```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

* **EF Core**: is an Object-Relational Mapping (ORM) framework for .Net. This framework  is used to work with database using .Net Objects.
* **Microsoft.EntityFrameworkCore.SqlServer**: This package was designed for SQL Server databases. It contains the components for EF Core interact with SQL Server, including database connection management, SQL generation, adn query translation
* **Microsoft.EntityFrameworkCore.Design**: Contains design-time components that are used for scaffolding database models and generating code migratons. **Scaffolding** means generating code or structure automatically based on existing data or templates. Summing up this issue, this package has the following purposes:

1. Database Migration
2. Scaffolding
3. DbContext Generation

* **Microsoft.EntityFrameworkCore.Tools**: This package provides commands-line tools for performing database-related tasks during development, such as generating and applying migrations, updating the database schema, and work DbContext


# Get started with Entity Framework Core

<https://youtu.be/SryQxUeChMc?list=PLdo4fOcmZ0oXCPdC3fTFA3Z79-eVH3K-s&t=101>
