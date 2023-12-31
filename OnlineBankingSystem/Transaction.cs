using System;

public class Transaction
{
    public DateTime Date { get; set; }
    public TransactionType Type { get; set; }
    public string AccountNumber { get; set; }
    public double Amount { get; set; }

    public Transaction(DateTime date, TransactionType type, string accountNumber, double amount)
    {
        Date = date;
        Type = type;
        AccountNumber = accountNumber;
        Amount = amount;
    }

    public override string ToString()
    {
        return $"Date: {Date}, Type: {Type}, Account Number: {AccountNumber}, Amount: {Amount:C}";
    }

    public static void Transfer(Account sourceAccount, Account targetAccount, double amount)
    {
        if (sourceAccount.Balance >= amount)
        {
            sourceAccount.Withdraw(amount);
            targetAccount.Deposit(amount);
            Console.WriteLine($"Transferred: ${amount} from Account {sourceAccount.AccountNumber} to Account {targetAccount.AccountNumber}");
        }
        else
        {
            Console.WriteLine("Transfer failed: Insufficient funds in the source account.");
        }
    }
}
