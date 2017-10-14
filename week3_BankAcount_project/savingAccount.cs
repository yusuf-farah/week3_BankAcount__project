using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_BankAcount_project
{
    class savingAccount:clientAccount
    {
        private double interest;

        public double Interest
        {
            get { return this.interest; }
            set { this.interest = value; }
        }
        public savingAccount(string name, decimal balance, int accountnumber, decimal withdrawMoney, decimal depositMoney, double interest)
        {
            this.Name = name;
            this.Balance = balance;
            this.AccountNumber = accountnumber;
            this.i

        }
    }
}
