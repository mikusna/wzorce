namespace _12_SwitchStatements;

public class Payment
{
    private readonly IPaymentFeeStrategy _paymentFeeStrategy;

    public Payment(IPaymentFeeStrategy paymentFeeStrategy)
    {
        _paymentFeeStrategy = paymentFeeStrategy;
    }

    public decimal DeterminePaymentFee(decimal amount)
    {
        return _paymentFeeStrategy.DeterminePaymentFee(amount);
    }
}

