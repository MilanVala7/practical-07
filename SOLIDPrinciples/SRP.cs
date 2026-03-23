namespace SOLIDPrinciples;

internal class Order
{
    public int Id;
    public double Amount;

    // Summary:
    // Purpose: Calculates final order amount.
    // Return Type: double
    
    public double CalculateTotal()
    {
        return Amount;
    }
}

class OrderService
{
    // Summary: 
    // Purpose: Handle order processing workflow
    // Return type: void
    public void Process(Order or)
    {
        Console.WriteLine("Processing Order ");
    }
}

class OredrRepository
{
    // Summary:
    // Purpose: Saves order to database.
    // Return Type: void
    public void Save(Order or)
    {
        Console.WriteLine("Order saved to database.");
    }
}

class InvoiceGenerator
{
    // Summary: 
    // Purpose: Generates the Invoice of the order.
    // Return Type: void
    public void Generate(Order or)
    {
        Console.WriteLine("Invoice generated.");
    }
}


