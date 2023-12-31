using System;

public class Program
{
    public static void Main()
    {
        Bank bank = new Bank();

        // Sample users
        User user1 = new User("Matthias Coba", "179 E 200 N ", "mattc@gmail.com", "coba123", "password123");
        User user2 = new User("Sara Navas", "150 College Ave", "saran@gmail.com", "sara456", "password456");

        // Sample accounts
        Account account1 = new Account(user1, "12345", AccountType.Checking, 1000);
        Account account2 = new Account(user2, "67890", AccountType.Savings, 500);

        bank.AddUser(user1);
        bank.AddUser(user2);
        bank.OpenAccount(account1);
        bank.OpenAccount(account2);

        bank.DisplayAllUsers();
        bank.DisplayAllAccounts();

        bank.PerformTransaction(new Transaction(DateTime.Now, TransactionType.Deposit, account1.AccountNumber, 500));
        bank.PerformTransaction(new Transaction(DateTime.Now, TransactionType.Withdrawal, account1.AccountNumber, 200));
        bank.PerformTransaction(new Transaction(DateTime.Now, TransactionType.Transfer, account1.AccountNumber, 300));

        bank.DisplayAllTransactions();
    }
}
