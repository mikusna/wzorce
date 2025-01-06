using System;

public class ShippingDetails
{
    public string ShippingMethod { get; set; }
    public string Destination { get; set; }

    public decimal CalculateShippingCost(decimal amount)
    {
        if (ShippingMethod == "Air")
        {
            return amount * 0.2m;
        }
        else if (ShippingMethod == "Sea")
        {
            return amount * 0.1m;
        }
        return amount * 0.15m;
    }
}

public class Order
{
    public ShippingDetails ShippingDetails { get; set; }
    public decimal Amount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        ShippingDetails shippingDetails = new ShippingDetails
        {
            ShippingMethod = "Air",
            Destination = "New York"
        };

        Order order = new Order
        {
            ShippingDetails = shippingDetails,
            Amount = 1000m 
        };

        decimal shippingCost = order.ShippingDetails.CalculateShippingCost(order.Amount);

        Console.WriteLine($"Koszt wysyłki: {shippingCost:C}");

        Console.ReadKey();
    }
}