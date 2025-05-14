using System;

interface IBankAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    void CheckBalance();
}

class SavingsAccount : IBankAccount
{
    public void Deposit(double amount) => Console.WriteLine($"Deposited ₹{amount} to Savings Account");
    public void Withdraw(double amount) => Console.WriteLine($"Withdrew ₹{amount} from Savings Account");
    public void CheckBalance() => Console.WriteLine("Checking Savings Account balance");
}

class CurrentAccount : IBankAccount
{
    public void Deposit(double amount) => Console.WriteLine($"Deposited ₹{amount} to Current Account");
    public void Withdraw(double amount) => Console.WriteLine($"Withdrew ₹{amount} from Current Account");
    public void CheckBalance() => Console.WriteLine("Checking Current Account balance");
}

class Program
{
    static void Main()
    {
        IBankAccount savings = new SavingsAccount();
        IBankAccount current = new CurrentAccount();
        
        savings.Deposit(5000);
        savings.Withdraw(2000);
        savings.CheckBalance();
        
        current.Deposit(10000);
        current.Withdraw(3000);
        current.CheckBalance();
    }
}