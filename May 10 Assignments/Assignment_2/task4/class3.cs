using System;

namespace ConsoleApp2
{
    class Payment
    {
        public decimal Amount;
        public string Currency;

        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Amount} {Currency}");
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount}");
        }

        public void ProcessPayment(decimal amount, string currency)
        {
            Console.WriteLine($"Processing payment of {amount} {currency}");
        }
    }

    class CreditCard : Payment
    {
        public int CardNumber;
    }

    class PayPal : Payment
    {
        public string Email;
    }
}
