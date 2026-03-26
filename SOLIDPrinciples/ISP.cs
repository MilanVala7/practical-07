namespace SOLIDPrinciples;

// Interface Segregation Principle (ISP)



// Base interface for all products.
public interface IProduct
{
    /// <summary>
    /// Purpose: Sets the price of a product.
    /// Return type: void
    /// </summary>
    /// <param name="price"> price to set</param>
    void SetPrice(decimal price);
}

// Interface for downloadable products.
public interface IDownloadable
{
    /// <summary>
    /// Purpose: Downloads the product.
    /// </summary>
    void Download();
}

// Interface for shippable products.
public interface IShippable
{
    /// <summary>
    /// Purpose: Ships the product.
    /// Return type: void
    /// </summary>
    void Ship();
}

// EBook implementation.
// Does NOT implement IShippable since EBooks don't require physical shipping.
public class EBook: IProduct, IDownloadable
{
    /// <summary>
    /// Purpose: Sets the price of the EBook.
    /// Return type: void
    /// </summary>
    /// <param name="price">price of the EBook</param>
    public void SetPrice(decimal price)
    {
        Console.WriteLine($"Price of EBook: {price}");
    }

    /// <summary>
    /// Purpose: Downloads the EBook to user's device.
    /// </summary>
    public void Download()
    {
        Console.WriteLine("EBook downloaded");
    }
}

// Laptop implementation.
// Does NOT implement IDownloadable since Laptops don't require download.
public class Laptop : IProduct, IShippable
{
    /// <summary>
    /// Purpose: Sets the price of the Laptop.
    /// </summary>
    /// <param name="price">price of the Laptop</param>
    public void SetPrice(decimal price)
    {
        Console.WriteLine($"Price of Laptop: {price}");
    }

    /// <summary>
    /// Purpose: Ships the Laptop to the customer.
    /// Return type: void
    /// </summary>
    public void Ship()
    {
        Console.WriteLine("Laptop shipped");
    }
}

// SoftwareWithUSB implementation.
// Implements all three interfaces as it combines digital and physical aspects.
public class SoftwareWithUSB : IProduct, IDownloadable, IShippable
{
    /// <summary>
    /// Purpose: Sets the price of the Software with USB package.
    /// return type: void
    /// </summary>
    /// <param name="price">The price of the software</param>
    public void SetPrice(decimal price)
    {
        Console.WriteLine($"Price of Software: {price}");
    }

    /// <summary>
    /// Purposse: Downloads the software to the user's device.
    /// </summary>
    public void Download()
    {
        Console.WriteLine("Software downloaded");
    }

    /// <summary>
    /// Purpose: Ships the USB to the customer.
    /// </summary>
    public void Ship()
    {
        Console.WriteLine("USB shipped");
    }
}