using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Decorator
{
    internal class DecoratorShop : Shop
    {
        public void SMSNotification(decimal amount)
        {
            Console.WriteLine($"Dziękujemy za zakupy! Z twojego konta pobrano {amount:C}.");
        }
        public void LoyaltyPoints(decimal amount)
        {
            int points = (int)(amount / 10);
            Console.WriteLine($"Na twoje konto dodano {amount:C} punktów lojalnościowych!");
        }
        public void RedirectToMain()
        {
            Console.WriteLine($"Za chwilę zostaniesz przekierowany na stronę główną.\n" +
                $"Nie zamykaj strony...");
        }

        public override void CreditCardPayment(decimal amount)
        {
            base.CreditCardPayment(amount);

            SMSNotification(amount);
            LoyaltyPoints(amount);
            RedirectToMain();
        }

    }

}
