using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Decorator
{
    public class Shop
    {
        public void MakePayment(Action<decimal> paymentMethod, decimal amount)
        {
            paymentMethod(amount);
        }

        public virtual void CreditCardPayment(decimal amount)
        {
            Console.WriteLine($"Kwota zamówienia: {amount:C}. \n" +
                              $"Płatność za pomocą karty kredytowej.");
        }

        public void PayPoPayment(decimal amount)
        {
            Console.WriteLine($"Kwota zamówienia: {amount:C}. \n" +
                              $"Płatność za pomocą PayPo.");
        }

        public void CashPayment(decimal amount)
        {
            Console.WriteLine($"Kwota zamówienia: {amount:C}. \n" +
                              $"Płatność za pomocą gotówki.");
        }
    }
}
