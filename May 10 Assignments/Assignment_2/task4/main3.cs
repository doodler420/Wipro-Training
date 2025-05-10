using System;
using ConsoleApp2;
class Program4
    {
        static void Main(string[] args)
        {
            CreditCard credit = new CreditCard { Amount = 150.75, Currency = "USD", CardNumber = 12345678 };
            credit.ProcessPayment();
            credit.ProcessPayment(99.99);

            PayPal paypal = new PayPal{ Amount = 50.5, Currency = "EUR", EmailAddress = "user@gmail.com" };
            paypal.ProcessPayment(50.5, "EUR");
        }
    }