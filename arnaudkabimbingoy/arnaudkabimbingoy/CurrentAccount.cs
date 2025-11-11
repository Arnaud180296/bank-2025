using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arnaudkabimbingoy
{

    internal sealed class CurrentAccount : Account
    {
        public double CreditLine { get; set; }

        public CurrentAccount(string number, double balance, double creditLine, Person owner) : base(number, balance, owner)
        {
            CreditLine = creditLine;
            //Console.WriteLine("Compte créé avec numéro : " + Number);
        }

        protected override double CalculateInterest()
        {
            if (base.Balance >= 0)
                return 3.0 / 100;
            return 9.75 / 100;
        }


        public override void Deposit(double amount)
        {
            base.Balance += amount;
        }

        public override void Withdraw(double amount)
        {
            base.Balance -= amount;
        }

        public override string ToString()
        {
            return $"{Number} / {Balance} / {CreditLine}";
        }
    }
}