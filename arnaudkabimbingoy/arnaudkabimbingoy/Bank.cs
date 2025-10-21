using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arnaudkabimbingoy
{
    internal sealed class Bank
    {
        public Dictionary<string, Account> Accounts { get; } = new Dictionary<string, Account>();
        public string Name { get; set; }
        public Bank(string name)
        {
            Name = name;
        }


        public void AddAccount(Account account)
        {
            if (!Accounts.ContainsKey(account.Number))
                Accounts.Add(account.Number, account);
            else
                Console.WriteLine("Ce numero de compte existe deja...");
        }

        public void DeleteAccount(string number)
        {
            Accounts.Remove(number);
        }

        public double GetBalance(string number)
        {
            return Accounts[number].Balance;
        }

        public double GetBalanceAllAccount(string owner)
        {
            double somme = 0;
            foreach (var item in Accounts)
            {
                if (item.Value.Owner.Firstname + " " + item.Value.Owner.Lastname == owner)
                {
                    somme += item.Value.Balance;
                }
            }
            return somme;
        }
    }
}
