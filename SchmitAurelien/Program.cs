// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var bank = new Bank("Our Bank");
var alice = new Person("Alice", "Smith", new DateTime(1990, 5, 15));
var bob = new Person("Bob", "Jones", new DateTime(1985, 3, 22));

bank.AddAccount(new CurrentAccount("A1", 500.0, 200.0, alice));
bank.AddAccount(new CurrentAccount("A2", 300.0, 150.0, alice));
bank.AddAccount(new CurrentAccount("B1", 400.0, 100.0, bob));

// account1.Deposit(200.0);
// bool success = account1.Withdraw(600.0); // Uses part of the credit line
// Console.WriteLine(account1);
// Console.WriteLine("Withdrawal successful: " + success);
// Console.WriteLine(account1.GetBalance());
// bank.AddAccount(account1);
// bank.DeleteAccount("123456789");

double aliceTotal = bank.GetTotalBalanceForPerson(alice);
Console.WriteLine($"Total balance for Alice: {aliceTotal:C}");