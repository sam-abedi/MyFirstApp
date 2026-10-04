
BankAccount account = new BankAccount();

account.Deposit(500);
account.Withdraw(300);

Console.WriteLine(account.Balance);


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

        public void Withdraw2(double amount)
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