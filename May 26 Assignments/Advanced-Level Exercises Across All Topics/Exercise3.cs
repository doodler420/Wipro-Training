using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class BankAccount
{
    List<string> transactions = new List<string>();
    const string file = "transactions.txt"; //File operations , this file path does not exist,the file is in the folder we jsut need to add path

    public BankAccount()
    {
        if (File.Exists(file))
            transactions = File.ReadAllLines(file).ToList();
        DisplaySummary();
    }

    public void Deposit(decimal amt)
    {
        AddTransaction("Deposit", amt);
    }

    public void Withdraw(decimal amt)
    {
        AddTransaction("Withdraw", amt);
    }

    void AddTransaction(string type, decimal amt)
    {
        var line = $"{type},{amt}";
        transactions.Add(line);
        File.WriteAllLines(file, transactions);
    }

    public void DisplaySummary()
    {
        Console.WriteLine("Transactions:");
        foreach (var t in transactions)
            Console.WriteLine(t.Replace(",", " ₹"));
    }
}

class Program
{
    static void Main()
    {
        var account = new BankAccount();

        account.Deposit(500);
        account.Withdraw(200);
        account.Deposit(1000);

        account.DisplaySummary();
    }
}
