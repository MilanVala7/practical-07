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
    /// <summary>
    /// Purpose: Handle order processing workflow
    /// Return type: void
    /// </summary>
    /// <param name="or">Order Object to be proccessed</param>
    public void Process(Order or)
    {
        Console.WriteLine($"Processing Order {or.Id}");
    }
}

class OredrRepository
{
    /// <summary>
    /// Purpose: Saves order to database.
    /// Return Type: void
    /// </summary>
    /// <param name="or">Order Object to be saved</param>
    public void Save(Order or)
    {
        Console.WriteLine($"Order {or.Id} saved to database.");
    }
}

class InvoiceGenerator
{
    // Summary: 
    // Purpose: Generates the Invoice of the order.
    // Return Type: void
    public void Generate(Order or)
    {
        Console.WriteLine($"Invoice generated for Order {or.Id} with amount {or.Amount}.");
    }
}


