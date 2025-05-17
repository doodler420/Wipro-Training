using System;

public abstract class PaymentMethod
{
    public abstract void ProcessPayment(decimal amount);
    public void ShowPaymentMethod(string method) => Console.WriteLine($"Payment Method: {method}");
}

public class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount) => Console.WriteLine($"Processing credit card payment of ₹{amount}");
}

public class UPIPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount) => Console.WriteLine($"Processing UPI payment of ₹{amount}");
}

public class Program
{
    public static void Main()
    {
        PaymentMethod creditCard = new CreditCardPayment();
        PaymentMethod upi = new UPIPayment();

        creditCard.ShowPaymentMethod("Credit Card");
        creditCard.ProcessPayment(1000);

        upi.ShowPaymentMethod("UPI");
        upi.ProcessPayment(500);
    }
}
