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

* **Microsoft.EntityFrameworkCore.Tools**: This package provides commands-line tools for performing database-related tasks during development, such as generating and applying migrations, updating the database schema, and working with DbContext.


## Creating Entities

1. In the ContosoPizza create a folder called **Models**
2. Inside the Models folder, create a class (entity) called **Product.cs**, as shown in the code below:

```
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizza.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    }    
}
```

3. Create a entity class called **Order**

```
namespace ContosoPizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null;
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
```

4. Create a entity class called **OrderDetail**

```
namespace ContosoPizza.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null;
        public Product Product { get; set; } = null;

    }
}
```

5. Now create a entity class called **Customer**

```
namespace ContosoPizza.Models
{
    public class Custom
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public ICollection<Order> Orders { get; set; } = null;

    }
}
```

## Database Context class

1. In the ContosoPizza create a folder called **Data**
2. Inside the folder Data, create a class called **ContosoPizzaContext** as shown in the code below:

```
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data
{
    public class ContosoPizzaContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null;
        public DbSet<Order> Orders { get; set; } = null;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null;
        public DbSet<Product> Products { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
```

**TIPS** 

* ContosoPizzaContext is derived from DBContext, which in turn, DBContext represents a session within the Database.
* The code below show a model of a string connection using SQL Server Express LocalDB

```
Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;
```

## The EF Core migrations feature

Provides a way to incrementally update the database schema to keep it in sync with the application's data model while preserving existing data in the database.

1. You need to create migrations

```
dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate
```

2. Now, update the database

```
dotnet ef database update
```

## Time to practice

1. Add products to Products table
```
using ContosoPizza.Data;
using ContosoPizza.Models;

...

using ContosoPizzaContext context = new ContosoPizzaContext();

Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 12.99M
};
context.Products.Add(veggieSpecial);

Product deluxeMeat = new Product()
{
    Name = "Deluxe Meat Pizza",
    Price = 9.9M
};
context.Products.Add(deluxeMeat);

context.SaveChanges();
```

2. Querying the products table

```
using ContosoPizzaContext context = new ContosoPizzaContext();

var products = context.Products
                .Where(p => p.Price > 10.00M)
                .OrderBy(p => p.Name);

foreach (var p in products)
{
    Console.WriteLine($"id.....: {p.Id}");
    Console.WriteLine($"Name...: {p.Name}");
    Console.WriteLine($"Price..: {p.Price}");
    Console.WriteLine(new string('-', 20));
}
```

3. Updating the entity

```
```