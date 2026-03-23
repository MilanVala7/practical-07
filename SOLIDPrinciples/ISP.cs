namespace SOLIDPrinciples;

public interface IProduct
{
    void SetPrice(decimal price);
}

public interface IDownloadable
{
    void Download();
}

public interface IShippable
{
    void Ship();
}

public class EBook: IProduct, IDownloadable
{
    public void SetPrice(decimal price)
    {
        Console.WriteLine($"Price of EBook: {price}");
    }

    public void Download()
    {
        Console.WriteLine("EBook downloaded");
    }
}

public class Laptop : IProduct, IShippable
{
    public void SetPrice(decimal price)
    {
        Console.WriteLine($"Price of Laptop: {price}");
    }
    public void Ship()
    {
        Console.WriteLine("Laptop shipped");
    }
}

public class SoftwareWithUSB : IProduct, IDownloadable, IShippable
{
    public void SetPrice(decimal price)
    {
        Console.WriteLine($"Price of Software: {price}");
    }
    public void Download()
    {
        Console.WriteLine("Software downloaded");
    }

    public void Ship()
    {
        Console.WriteLine("USB shipped");
    }
}