using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SwitchStatements
{
    public class CreditCardFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount)
        {
            return amount * 0.02m;
        }
    }

    public class PayPalFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount)
        {
            return amount * 0.03m;
        }
    }

    public class BankTransferFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount)
        {
            return amount * 0.01m;
        }
    }

}
