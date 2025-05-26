using System;
using System.Collections.Generic;

// Interface
public interface IPaymentProcessor
{
    void ProcessPayment();
}

// Abstract class
public abstract class PaymentGateway : IPaymentProcessor
{
    public string GatewayName;
    public abstract void ProcessPayment();
    public abstract void Validate();
}

// Razorpay
public class Razorpay : PaymentGateway
{
    public Razorpay()
    {
        GatewayName = "Razorpay";
    }

    public override void Validate()
    {
        Console.WriteLine($"{GatewayName}: validation successful.");
    }

    public override void ProcessPayment()
    {
        Validate();
        Console.WriteLine($"{GatewayName} processed payment.");
    }
}

// PayPal
public class PayPal : PaymentGateway
{
    public PayPal()
    {
        GatewayName = "PayPal";
    }

    public override void Validate()
    {
        Console.WriteLine($"{GatewayName}: validation successful.");
    }

    public override void ProcessPayment()
    {
        Validate();
        Console.WriteLine($"{GatewayName} processed payment.");
    }
}

// Stripe
public class Stripe : PaymentGateway
{
    public Stripe()
    {
        GatewayName = "Stripe";
    }

    public override void Validate()
    {
        Console.WriteLine($"{GatewayName}: validation successful.");
    }

    public override void ProcessPayment()
    {
        Validate();
        Console.WriteLine($"{GatewayName} processed payment.");
    }
}

// Main Program
public class Program
{
    public static void Main()
    {
        List<IPaymentProcessor> processors = new List<IPaymentProcessor>
        {
            new Razorpay(),
            new PayPal(),
            new Stripe()
        };

        foreach (var processor in processors)
        {
            processor.ProcessPayment();
        }
    }
}
