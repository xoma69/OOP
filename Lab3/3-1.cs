using System;

abstract class Account
{
    public string Owner { get; set; }
    public decimal Balance { get; set; }

    public Account(string owner, decimal balance)
    {
        Owner = owner;
        Balance = balance;
    }

    public abstract decimal CalculateInterest();
}

class SavingsAccount : Account
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(string owner, decimal balance, decimal rate)
        : base(owner, balance)
    {
        InterestRate = rate;
    }

    public override decimal CalculateInterest()
    {
        return Balance * InterestRate / 100;
    }
}

class Program1
{
    static void Main()
    {
        SavingsAccount account = new SavingsAccount("Ivan", 1000m, 5m);
        Console.WriteLine($"Interest for {account.Owner}: {account.CalculateInterest()}");
    }
}
