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

        public double ApplyInterest()
        {
            return Balance; //+ CalculateInterest();
        }
        public virtual void Withdraw(double amount)
        {

        }
        public virtual void Deposit(double amount)
        {

        }
        protected abstract double CalculateInterest(Account account);
    }
}
