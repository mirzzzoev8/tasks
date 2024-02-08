namespace Task2;
public class Account
{
    string name;
    double balance;

    public Account(string accountName, double _balance)
    {
        name = accountName;
        balance = _balance;
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public override string ToString()
    {
        return "Account name : " + name + ", Balance : " + balance;
    }
}
