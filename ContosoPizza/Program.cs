using System.Net;
using ContosoPizza.Data;
using ContosoPizza.Models;

public class Program
{
    private static void Main(string[] args)
    {
        using ContosoPizzaContext context = new ContosoPizzaContext();

        var products = context.Products
                        .OrderBy(p => p.Name);

        foreach (var p in products)
        {
            Console.WriteLine($"id.....: {p.Id}");
            Console.WriteLine($"Name...: {p.Name}");
            Console.WriteLine($"Price..: {p.Price}");
            Console.WriteLine(new string('-', 20));
        }


        // Adding products to the Product table ------------------------------------

        // using ContosoPizzaContext context = new ContosoPizzaContext();
        // Product veggieSpecial = new Product()
        // {
        //     Name = "Veggie Special Pizza",
        //     Price = 12.99M
        // };
        // context.Products.Add(veggieSpecial);

        // Product deluxeMeat = new Product()
        // {
        //     Name = "Deluxe Meat Pizza",
        //     Price = 9.9M
        // };
        // context.Products.Add(deluxeMeat);

        // context.SaveChanges();

        // Adding customers to the Customer table ------------------------------------

     /*   using ContosoPizzaContext context = new ContosoPizzaContext();

        var meusClientes = new List<Customer>
        {
            new Customer { FirstName = "Deyvid Rannyere", LastName = "Moraes", Email = "deyran@gmail.com" },
            new Customer { FirstName = "Márcia", LastName = "Moraes", Email = "marciamoraes80@hotmail.com" },
            new Customer { FirstName = "Lara Hellena", LastName = "Moraes", Email = "larahellena17@gmail.com" }
        };

        context.Customers.AddRange(meusClientes);
        context.SaveChanges();*/
    }
}