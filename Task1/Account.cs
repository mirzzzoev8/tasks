namespace Task1;
public class Account
{
    private double balance;

    public Account(double _balance)
    {
        balance = _balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void PrintBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
}
