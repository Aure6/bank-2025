// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var bank = new Bank("Our Bank");
var alice = new Person("Alice", "Smith", new DateTime(1990, 5, 15));
var bob = new Person("Bob", "Jones", new DateTime(1985, 3, 22));

var acc = new SavingsAccount("A3", 1000.0, 0.05, alice);
bank.AddAccount(acc);

acc.ApplyInterests();
Console.WriteLine(acc.Balance); // 1050 si taux = 5%

bank.AddAccount(new CurrentAccount("A1", 500.0, 200.0, alice));
bank.AddAccount(new CurrentAccount("A2", 300.0, 150.0, alice));
bank.AddAccount(new CurrentAccount("B1", 400.0, 100.0, bob));

double aliceTotal = bank.GetTotalBalanceForPerson(alice);
Console.WriteLine($"Total balance for Alice: {aliceTotal:C}");