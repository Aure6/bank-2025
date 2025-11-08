public class Bank
{
    public Dictionary<string, CurrentAccount> Accounts { get; }
    public string Name;

    public Bank(string name)
    {
        Name = name;
        Accounts = new Dictionary<string, CurrentAccount>();
    }

    public void AddAccount(CurrentAccount account)
    {
        if (account != null && !Accounts.ContainsKey(account.Number))
        {
            Accounts.Add(account.Number, account);
        }
    }

    public void DeleteAccount(string number)
    {
        if (Accounts.ContainsKey(number))
        {
            Accounts.Remove(number);
        }
    }

    public double GetTotalBalanceForPerson(Person person)
    {
        return Accounts.Values
            .Where(account => account.Owner == person)
            .Sum(account => account.Balance);
    }
}
