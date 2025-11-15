interface IAccount
{
    // Propriété en lecture seule pour consulter le solde
    double Balance { get; }

    void Deposit(double amount);
    bool Withdraw(double amount);
}

interface IBankAccount : IAccount
{
    void ApplyInterests();

    // Propriétés en lecture seule pour identifier le compte
    Person Owner { get; }
    string Number { get; }
}

public abstract class Account : IBankAccount
{
    public string Number { get; set; }
    // public double CreditLine { get; set; }
    public double InterestRate { get; set; }
    public Person Owner { get; set; }

    private double _balance;
    public double Balance => _balance;

    public Account(string number, double initialBalance, double interestRate, Person owner)
    {
        Number = number;
        _balance = initialBalance;
        // CreditLine = creditLine;
        InterestRate = interestRate;
        Owner = owner;
    }

    public bool Withdraw(double amount)
    {
        _balance -= amount;
        return true;
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

    protected abstract double CalculInterests();
    public void ApplyInterests()
    {
        _balance += CalculInterests();
    }

}