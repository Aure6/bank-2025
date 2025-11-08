public class Account
{
    public string Number { get; set; }
    public double CreditLine { get; set; }
    public Person Owner { get; set; }

    private double _balance;
    public double Balance => _balance;

    public Account(string number, double initialBalance, double creditLine, Person owner)
    {
        Number = number;
        _balance = initialBalance;
        CreditLine = creditLine;
        Owner = owner;
    }

    public bool Withdraw(double amount)
    {
        if (_balance - amount >= -CreditLine)
        {
            _balance -= amount;
            return true;
        }
        return false; // insufficient funds
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public double GetBalance()
    {

        return Balance;
    }
}