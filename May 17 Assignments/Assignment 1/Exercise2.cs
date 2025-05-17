using System;

public interface ISupportTicket
{
    void CreateTicket(string issue);
    void ResolveTicket(int ticketId);
}

public class EmailSupport : ISupportTicket
{
    public void CreateTicket(string issue) => Console.WriteLine($"Creating ticket via Email: {issue}");
    public void ResolveTicket(int ticketId) => Console.WriteLine($"Resolving ticket {ticketId} via Email");
}

public class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue) => Console.WriteLine($"Creating ticket via Phone: {issue}");
    public void ResolveTicket(int ticketId) => Console.WriteLine($"Resolving ticket {ticketId} via Phone");
}

public class Program
{
    public static void Main()
    {
        ISupportTicket email = new EmailSupport();
        ISupportTicket phone = new PhoneSupport();

        email.CreateTicket("Login issue");
        email.ResolveTicket(101);
        phone.CreateTicket("Payment error");
        phone.ResolveTicket(102);
    }
}