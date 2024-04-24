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

**EF Core**: is an Object-Relational Mapping (ORM) framework for .Net. This framework  is used to work with database using .Net Objects.

# Get started with Entity Framework Core

<https://youtu.be/SryQxUeChMc?list=PLdo4fOcmZ0oXCPdC3fTFA3Z79-eVH3K-s&t=101>
