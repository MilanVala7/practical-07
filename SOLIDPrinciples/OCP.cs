namespace SOLIDPrinciples;

interface INotify
{
    // Summary: 
    // Purpose: Send notification to the user.
    // Return Type: Void
    void Send(string message);
}

class EmailNotification: INotify
{
    // Summary: 
    // Purpose: Send notification to the user via email.
    // Return Type: Void
    public void Send(string msg)
    {
        Console.WriteLine("Email Notification: " + msg);
    }
}

class SMSNotification: INotify
{
    // Summary: 
    // Purpose: Send notification to the user via SMS.
    // Return Type: Void
    public void Send(string msg)
    {
        Console.WriteLine("SMS Notification: " + msg);
    }
}

class WhatsAppNotification: INotify
{
    // Summary: 
    // Purpose: Send notification to the user via whatsapp.
    // Return Type: Void
    public void Send(string msg)
    {
        Console.WriteLine("WhatsApp Notification: " + msg);
    }
}

class NotificationService
{
    // Summary: 
    // Purpose: Send notification without changing exsiting code.
    // Return type: void 
    public void Notify(INotify n, string msg)
    {
        n.Send(msg);
    }
}