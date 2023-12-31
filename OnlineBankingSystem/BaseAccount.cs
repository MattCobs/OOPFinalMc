using System;

public enum AccountType
{
    Savings,
    Checking,
    CreditCard
}

public class BaseAccount
{
    public string AccountNumber { get; set; } = string.Empty;
    public double Balance { get; set; }
    public AccountType Type { get; set; }

    public virtual void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited: ${amount}. New Balance: ${Balance}");
    }

    public virtual void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount}. New Balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public virtual void CheckBalance()
    {
        Console.WriteLine($"Account Balance: ${Balance}");
    }
}
