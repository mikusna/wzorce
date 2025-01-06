using System;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

    public Product(string name, decimal price, int stockQuantity)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public string GetFormattedPrice()
    {
        return $"{Price:F2} zł"; 
    }

    public bool IsInStock()
    {
        return StockQuantity > 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product("Kubek", 21.00m, 20),
            new Product("Świeczka", 37.00m, 0),

        };

        foreach (var product in products)
        {
            Console.WriteLine($"Produkt: {product.Name}");
            Console.WriteLine($"Cena: {product.GetFormattedPrice()}");

            if (product.IsInStock())
            {
                Console.WriteLine("Produkt na magazynie.");
            }
            else
            {
                Console.WriteLine("Brak produktu na magazynie.");
            }

            Console.WriteLine();  
        }

        Console.ReadKey();
    }
}
