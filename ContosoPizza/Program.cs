using ContosoPizza.Data;
using ContosoPizza.Models;

public class Program
{
    private static void Main(string[] args)
    {
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
    }
}