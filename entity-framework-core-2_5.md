# Getting Started with Entity Framework Core [2 of 5]

In this chapter we will see how to use the Entity Framework core to work with existing database, this process is called **reverse engineering**. To show how to make reverse engineering, the database created in the previous chapter will be used.

## To get started, follow the steps below

1. Delete de Data and Models folder
2. Now it's time to use the Scaffold-DbContext command link. First, make a copy of the connection string, type and execute the following command line.

```
dotnet ef dbcontext scaffold "Data Source=Financeiro01\MSSQLSERVER01;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Models
```

* **dotnet ef dbcontext scaffold**: This command line is used to generate entity class in a DbContext using existing database schema as base.
* **"Data Source=Financeiro01\MSSQLSERVER01;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;TrustServerCertificate=True"**: String connection
* **Microsoft.EntityFrameworkCore.SqlServer**: This is the database provider that EF Core will use to communicate with SQL Server.
* **--context-dir Data**: This parameter creates the folder where the DbContext will be generated. In that case, the DbContext class will be generated in the **Data** folder
* **--output-dir Models**: This parameter indicates where the entity classes will be generated. In this case, the entity classes will be generated in the **Models** folder

3. To automatically create entity classes with DataAnnotation, you must use **Package Manager Console** in Visual Studio. The code below shows how to create entity classes with DataAnnotation

```
Scaffold-DbContext "Data Source=Financeiro01\MSSQLSERVER01;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -ContextDir Data -OutputDir Models -DataAnnotation
```

## What do we do when the database schema changes?

### There are two strategies:

1. **Manual approach**

This approach requires you to manually edit your entity model to keep it sync with the database schema. The generated DbContext and model classes can be though of as starting point for ongoing development similar to scaffolded razor pages in an ASP.NET Core Web App

2. XXX