public class CurrentAccount : Account
{
    public CurrentAccount(string number, double balance, double interestRate, Person owner)
            : base(number, balance, interestRate, owner)
    {
    }

    protected override double CalculInterests()
    {
        if (this.Balance >= 0)
            return Balance * 0.0975;
        else return Balance * 0.03;
    }
}