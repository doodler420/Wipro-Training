using System;
abstract class PaymentGateway
{
    //concrete
    public void ShowGatewayName() => Console.WriteLine("Processing payment through gateway");
    //abstract
    public abstract void ProcessPayment(double amount);
}

class StripeGateway : PaymentGateway
{
    public override void ProcessPayment(double amount) => 
        Console.WriteLine($"Processing payment through Stripe: ₹{amount}");
}

class PayPalGateway : PaymentGateway
{
    public override void ProcessPayment(double amount) => 
        Console.WriteLine($"Processing payment through PayPal: ₹{amount}");
}

class Program
{
    static void Main()
    {
        PaymentGateway stripe = new StripeGateway();
        PaymentGateway paypal = new PayPalGateway();
        
        stripe.ShowGatewayName();
        stripe.ProcessPayment(1000);
        
        paypal.ShowGatewayName();
        paypal.ProcessPayment(1500);
    }
}