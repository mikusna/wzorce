using System;

public class ProductDetails
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public ProductDetails(string name, string category, decimal price, int quantity)
    {
        Name = name;
        Category = category;
        Price = price;
        Quantity = quantity;
    }
}

public class ProductManager
{
    public void RegisterProduct(ProductDetails productDetails)
    {
        Console.WriteLine($"Product: {productDetails.Name}, Category: {productDetails.Category}, Price: {productDetails.Price}, Quantity: {productDetails.Quantity}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProductDetails productDetails = new ProductDetails("Kubek", "Kuchnia", 21.00m, 37);

        ProductManager productManager = new ProductManager();
        productManager.RegisterProduct(productDetails);

        Console.ReadKey();
    }
}