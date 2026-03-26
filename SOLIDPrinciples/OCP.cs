namespace SOLIDPrinciples;

interface INotify
{
    /// Summary: 
    /// Purpose: Send notification to the user.
    /// Return Type: Void
    /// <param name="message">Message to be display in Notification</param>
    void Send(string message);
}

class EmailNotification: INotify
{
    /// <summary>
    /// Purpose: Send notification to the user via email.
    /// Return Type: Void 
    /// </summary>
    /// <param name="msg">Message to be display in Email Notification</param>

    public void Send(string msg)
    {
        Console.WriteLine("Email Notification: " + msg);
    }
}

class SMSNotification: INotify
{
    /// <summary>
    ///  Purpose: Send notification to the user via SMS.
    ///  Return Type: Void
    /// </summary>
    /// <param name="msg">Message to be display in SMS Notification</param>
    public void Send(string msg)
    {
        Console.WriteLine("SMS Notification: " + msg);
    }
}

class WhatsAppNotification: INotify
{
    /// <summary> 
    /// Purpose: Send notification to the user via whatsapp.
    /// Return Type: Void
    /// </summary>
    /// <param name="msg">Message to be display in Whatsapp Notification</param>
    public void Send(string msg)
    {
        Console.WriteLine("WhatsApp Notification: " + msg);
    }
}

class NotificationService
{
    /// <summary>
    /// Purpose: Send notification without changing exsiting code.
    /// Return type: void
    /// </summary>
    /// <param name="n">INotify interface object</param>
    /// <param name="msg">Message to give as parameter to the Send method</param>  
    public void Notify(INotify n, string msg)
    {
        n.Send(msg);
    }
}