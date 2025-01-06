using _09_Decorator;

class Program
{
    static void Main()
    {
        decimal amount = 21.37M;

        DecoratorShop shop = new DecoratorShop();

        Console.WriteLine("Płatność PayPo:");
        shop.PayPoPayment(amount);
        Console.WriteLine();

        Console.WriteLine("Płatność gotówką:");
        shop.CashPayment(amount);
        Console.WriteLine();

        Console.WriteLine("Płatność kartą kredytową:");
        shop.CreditCardPayment(amount);
        Console.WriteLine();

        Console.ReadKey();
    }
}