
BankAccount account = new BankAccount();

account.Deposit(500);
account.Withdraw(300);
Console.WriteLine("your current balance");
class BankAccount
{
    public double Balance { get; private set; }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
    }public double GetBalance()
{
    return Balance;
}

}