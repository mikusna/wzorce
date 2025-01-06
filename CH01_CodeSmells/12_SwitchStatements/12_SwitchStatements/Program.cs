using System;
namespace _12_SwitchStatements;

class Program
{
    static void Main(string[] args)
    {
        decimal amount = 1000m;

        IPaymentFeeStrategy creditCardStrategy = new CreditCardFeeStrategy();
        Payment payment = new Payment(creditCardStrategy);
        Console.WriteLine($"Credit Card Fee: {payment.DeterminePaymentFee(amount):C}");

        IPaymentFeeStrategy paypalStrategy = new PayPalFeeStrategy();
        payment = new Payment(paypalStrategy);
        Console.WriteLine($"PayPal Fee: {payment.DeterminePaymentFee(amount):C}");

        IPaymentFeeStrategy bankTransferStrategy = new BankTransferFeeStrategy();
        payment = new Payment(bankTransferStrategy);
        Console.WriteLine($"Bank Transfer Fee: {payment.DeterminePaymentFee(amount):C}");

        Console.ReadKey();
    }
}