using ContosoPizza.Data;
using ContosoPizza.Models;

public class Program
{
    private static void Main(string[] args)
    {
        using ContosoPizzaContext context = new ContosoPizzaContext();

        var veggieSpecial = context.Products
                                .Where(p => p.Name == "Veggie Special Pizza")
                                .FirstOrDefault();

        if (veggieSpecial is Product)
        {
            veggieSpecial.Price = 5.99M;
        }
        context.SaveChanges();

        var products = context.Products
                        .Where(p => p.Price < 10.00M)
                        .OrderBy(p => p.Name);

        foreach (var p in products)
        {
            Console.WriteLine($"id.....: {p.Id}");
            Console.WriteLine($"Name...: {p.Name}");
            Console.WriteLine($"Price..: {p.Price}");
            Console.WriteLine(new string('-', 20));
        }
    }
}