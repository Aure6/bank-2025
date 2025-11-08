public class CurrentAccount : Account
{
    public CurrentAccount(string number, double balance, double interestRate, Person owner)
            : base(number, balance, interestRate, owner)
    {
    }
}