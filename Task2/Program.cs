using Task2;
Account heikkisAccount = new Account("Heikkis account ", 1000.0);
Account personalAccount = new Account("Personal account ", 0);
heikkisAccount.Withdraw(100.0);
personalAccount.Deposit(100.0);
Console.WriteLine(heikkisAccount.ToString());
Console.WriteLine(personalAccount.ToString());