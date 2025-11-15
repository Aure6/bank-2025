public class SavingsAccount : Account
{
    public SavingsAccount(string number, double balance, double interestRate, Person owner)
            : base(number, balance, 4.5, owner)
    {
    }

    protected override double CalculInterests()
    {
        return Balance * 0.045;
    }
}