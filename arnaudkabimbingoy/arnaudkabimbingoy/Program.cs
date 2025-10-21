using arnaudkabimbingoy;
using System;
using System.Security.Principal;

internal class Program
{
    public static void Main()
    {
        Bank bank1 = new Bank("ING BELGIUM");
        Person person1 = new Person("Ester", "Exposito", new DateTime(2000, 01, 26));
        Person person2 = new Person("Marion", "Cotillard", new DateTime(1975, 09, 30));
        Person person3 = new Person("Georgina", "Rodriguez", new DateTime(1994, 01, 27));
        //Person person4 = new Person("Ester", "Exposito", new DateTime(2000, 01, 26));

        Account currentAccount1 = new CurrentAccount(3200000, 750000, person1);
        Account currentAccount2 = new CurrentAccount(46000000, 17000000, person2);
        Account currentAccount3 = new CurrentAccount(930000000, 120000000, person3);
        Account currentAccount4 = new CurrentAccount(31, 10, person1);

        Account savingAccount1 = new SavingsAccount(782057, person1);

        bank1.AddAccount(currentAccount1);
        bank1.AddAccount(currentAccount2);
        bank1.AddAccount(currentAccount3);
        bank1.AddAccount(currentAccount4);
        bank1.AddAccount(savingAccount1);

        Console.WriteLine($"Voici le total de tous les comtpes associé à {person1.Firstname} {person1.Lastname} {bank1.GetBalanceAllAccount("Ester Exposito")}");
    }
}