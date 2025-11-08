// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var bank = new Bank("Our Bank");
var owner = new Person("Alice", "Smith", new DateTime(1990, 5, 15));
var account = new CurrentAccount("123456789", 500.0, 200.0, owner);

account.Deposit(200.0);
bool success = account.Withdraw(600.0); // Uses part of the credit line

Console.WriteLine(account);
Console.WriteLine("Withdrawal successful: " + success);

Console.WriteLine(account.GetBalance());

bank.AddAccount(account);
bank.DeleteAccount("123456789");