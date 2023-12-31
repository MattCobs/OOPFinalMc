using System;
using System.Collections.Generic;

public class Bank
{
    private List<User> users;
    private List<Account> accounts;
    private List<Transaction> transactions;

    public Bank()
    {
        users = new List<User>();
        accounts = new List<Account>();
        transactions = new List<Transaction>();
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void OpenAccount(Account account)
    {
        accounts.Add(account);
    }

    public void PerformTransaction(Transaction transaction)
    {
        transactions.Add(transaction);
        var account = accounts.Find(acc => acc.AccountNumber == transaction.AccountNumber);
        switch (transaction.Type)
        {
            case TransactionType.Deposit:
                account.Deposit(transaction.Amount);
                break;
            case TransactionType.Withdrawal:
                account.Withdraw(transaction.Amount);
                break;
            case TransactionType.Transfer:
                var transferAccount = accounts.Find(acc => acc.AccountNumber != transaction.AccountNumber);
                if (transferAccount != null)
                {
                    Transaction.Transfer(account, transferAccount, transaction.Amount);
                }
                break;
            default:
                Console.WriteLine("Invalid transaction type.");
                break;
        }
    }

    public void DisplayAllUsers()
    {
        Console.WriteLine("All Users:");
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }

    public void DisplayAllAccounts()
    {
        Console.WriteLine("All Accounts:");
        foreach (var account in accounts)
        {
            Console.WriteLine(account);
        }
    }

    public void DisplayAllTransactions()
    {
        Console.WriteLine("All Transactions:");
        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}
