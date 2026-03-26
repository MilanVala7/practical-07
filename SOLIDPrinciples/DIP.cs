namespace SOLIDPrinciples;

// Dependency Inversion Principle (DIP)
// This demonstrates how high-level modules should not depend on low-level modules.
// Both should depend on abstractions. 

public interface IPaymentMethod
{
    /// <summary>
    /// Purpose: Processes a payment using the specific payment method.
    /// Return type: void
    /// </summary>
    void ProcessPayment();
}

// CreditCard payment implementation.
public class CreditCard : IPaymentMethod
{
    /// <summary>
    /// Purpose: Processes a credit card payment.
    /// </summary>
    public void ProcessPayment()
    {
        Console.WriteLine($"Processing credit card payment");
    }
}

// UPI payment implementation. implements IpaymentMethod interface.
public class UPI : IPaymentMethod
{
    /// <summary>
    /// Purpose: Processes a UPI payment.
    /// </summary>
    public void ProcessPayment()
    {
        Console.WriteLine($"Processing UPI payment");
    }
}

public class PaymentProcessor
{
    // Allows switching between different payment implementations.
    private readonly IPaymentMethod pm;

    //Demonstrates constructor-based dependency injection.
    /// <param name="paymentMethod">IPaymentMethod object to use for processing payments</param>
    public PaymentProcessor(IPaymentMethod paymentMethod)
    {
        pm = paymentMethod;
    }

    /// <summary>
    /// Executes the payment using the injected payment method.
    /// </summary>
    public void ExecutePayment()
    {
        pm.ProcessPayment();
    }
}

