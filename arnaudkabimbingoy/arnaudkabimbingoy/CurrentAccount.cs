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

        public CurrentAccount(double balance, double creditLine, Person owner)
        {
            Number = "BE" + new Random().NextInt64(99999999999999).ToString();
            base.Balance = balance;
            CreditLine = creditLine;
            Owner = owner;

            //Console.WriteLine("Compte créé avec numéro : " + Number);
        }

        protected override double CalculateInterest(Account account)
        {
            //Si c'est un Saving Account alors 4.5%
            //sinon Si c'est un Current Account et que le solde est positif alores 3%
            //sinon 9.75%

            /*
             à l'aide account je dois recuperer le type de compte deriere.
             */
            return 0;
        }


        public override void Deposit(double amount)
        {

        }

        public override void Withdraw(double amount)
        {

        }

        public override string ToString()
        {
            return $"{Number} / {Balance} / {CreditLine}";
        }
    }
}