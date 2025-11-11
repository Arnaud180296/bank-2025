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
