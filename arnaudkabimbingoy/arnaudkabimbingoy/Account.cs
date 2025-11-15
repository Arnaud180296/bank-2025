using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arnaudkabimbingoy
{
    internal abstract class Account : IBankAccount
    {
        public string Number { get; private set; }
        public double Balance { get; private set;}
        public Person Owner { get; private set; }

        public Account (string number, Person owner)
        {
            Number = number;
            Owner = owner;
        }
        public Account(string number, double balance, Person owner)
        {
            Number = number;
            Balance = balance;
            Owner = owner;
        }

        public double ApplyInterest()
        {
            return Balance + (Balance * CalculateInterest());
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }
        
        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }
        
        protected abstract double CalculateInterest();
    }
}
