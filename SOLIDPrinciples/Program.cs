namespace SOLIDPrinciples;

internal class Program
{
    static void Main()
    {
        // Single Responsibility Principle:

        Console.WriteLine("Single Responsibility Principal:");
        Order o1 = new Order { Id = 1, Amount = 5000 };

        OrderService p1 = new OrderService();
        OredrRepository r1 = new OredrRepository();
        InvoiceGenerator ig = new InvoiceGenerator();

        p1.Process(o1);
        r1.Save(o1);
        ig.Generate(o1);

        Console.WriteLine("Total Amount: " + o1.CalculateTotal());
        Console.WriteLine();


        // Open Closed Principle:

        Console.WriteLine("Open Closed Principle: ");

        NotificationService n = new NotificationService();

        INotify email = new EmailNotification();
        INotify sms = new SMSNotification();
        INotify wa = new WhatsAppNotification();

        n.Notify(email, "Notification via Email");
        n.Notify(sms, "Notification via SMS");
        n.Notify(wa, "Notification via WhatsApp");
        Console.WriteLine();


        // Liskov Substitution Principle:
        Console.WriteLine("Liskov Substitution Principle: ");

        WordDocs file1 = new WordDocs();
        file1.Write("Word Document");
        file1.Read();

        PdfDocs file2 = new PdfDocs("Read Only Document");
        file2.Read();

        Console.WriteLine();


        // Interface Segregation Principle:

        Console.WriteLine("Interface Segregation Principle: ");

        EBook ebook = new EBook();
        ebook.SetPrice(500);
        ebook.Download();

        Laptop laptop = new Laptop();
        laptop.SetPrice(60000);
        laptop.Ship();

        SoftwareWithUSB s = new SoftwareWithUSB();
        s.SetPrice(55000);
        s.Download();
        s.Ship();

        Console.WriteLine();

        
        // Dependency Inversion Principle

        Console.WriteLine("Dependency Inversion Principle: ");

        CreditCard creditCardPayment = new CreditCard();
        PaymentProcessor paymentP1 = new PaymentProcessor(creditCardPayment);
        paymentP1.ExecutePayment();

        UPI upiPayment = new UPI();
        PaymentProcessor paymentP2 = new PaymentProcessor(upiPayment);
        paymentP2.ExecutePayment();

    }
}