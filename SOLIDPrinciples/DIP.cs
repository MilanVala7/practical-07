namespace SOLIDPrinciples;

public interface IPaymentMethod
{
    void ProcessPayment();
}

public class CreditCard : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine($"Processing credit card payment");
    }
}
public class UPI : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine($"Processing UPI payment");
    }
}
public class PaymentProcessor
{
    private readonly IPaymentMethod _paymentMethod;
    public PaymentProcessor(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }
    public void ExecutePayment()
    {
        _paymentMethod.ProcessPayment();
    }
}

