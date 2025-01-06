using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_SwitchStatements
{
    public interface IPaymentFeeStrategy
    {
        decimal DeterminePaymentFee(decimal amount);
    }

}
