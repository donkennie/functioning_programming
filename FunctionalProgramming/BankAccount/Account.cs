using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.BankAccount
{
    public abstract class Account
    {
        public abstract void BankName();

            private protected static uint Account_Number= 3140078526;

            public string Number { get; }

            public Account()
            {
                this.Number = Account_Number.ToString();
                ++Account_Number;
            }
    }
}
