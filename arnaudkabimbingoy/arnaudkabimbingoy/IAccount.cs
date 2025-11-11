using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arnaudkabimbingoy
{
    internal interface IAccount
    {
        double Balance { get; }

        public abstract void Deposit();
        public abstract void Withdraw();
    }
}
