using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arnaudkabimbingoy
{
    internal sealed class SavingsAccount : Account
    {
        public DateTime DateLastWithdraw { get; set; }
        public SavingsAccount(double balance, Person owner)
        {
            Number = "BE" + new Random().NextInt64(99999999999999).ToString();
            base.Balance = balance;
            Owner = owner;
        }
        protected override double CalculateInterest()
        {
            return 4.5 / 100;
        }
        public override void Deposit(double amount)
        {
            base.Balance += amount;
        }
        public override void Withdraw(double amount)
        {
            base.Balance -= amount;
        }
    }
}

