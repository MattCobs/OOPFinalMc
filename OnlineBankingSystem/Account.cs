public class Account : BaseAccount
{
    public User AccountHolder { get; set; }

    public Account(User accountHolder, string accountNumber, AccountType type, double initialBalance)
    {
        AccountHolder = accountHolder;
        AccountNumber = accountNumber;
        Type = type;
        Balance = initialBalance;
    }

    public override void Withdraw(double amount)
    {
        if (Type == AccountType.Savings && Balance - amount < 100)
        {
            Console.WriteLine("Withdrawal failed: Minimum balance for savings account must be maintained.");
        }
        else
        {
            base.Withdraw(amount);
        }
    }

    public override string ToString()
    {
        return $"Account Holder: {AccountHolder.Name}, Account Number: {AccountNumber}, Type: {Type}, Balance: {Balance:C}";
    }
}
