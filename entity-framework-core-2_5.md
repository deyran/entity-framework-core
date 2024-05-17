# Getting Started with Entity Framework Core [2 of 5]

In this chapter we will see how to use the Entity Framework core to work with existing database, this process is called **reverse engineering**. To show how to make reverse engineering, the database created in the previous chapter will be used.

## To get started, follow the steps below

1. Delete de folder Models
2. Now it's time to use the Scaffold-DbContext command link. First, make a copy of the connection string, type and execute the following command line.

```
dotnet ef dbcontext scaffold "Data Source=Financeiro01\MSSQLSERVER01;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer --context-dir Data --output-dir Models
```

3. AAA