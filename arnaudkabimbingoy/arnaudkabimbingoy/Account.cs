using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arnaudkabimbingoy
{
    internal abstract class Account
    {
        public string Number { get; set; }
        public double Balance { get; protected set; }
        public Person Owner { get; set; }


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
        public abstract void Withdraw(double amount);
        
        public abstract void Deposit(double amount);
        
        protected abstract double CalculateInterest();
    }
}
