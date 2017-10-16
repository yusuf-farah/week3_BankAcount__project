using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_BankAcount_project
{
     class checkingAccount:accounts
    {

       
        public checkingAccount(decimal accountBalance, int accountnumber, decimal withdrawfunds, decimal depositfunds, bool accountType)

        {
            this.AccountBalance = accountBalance;
            this.AccountNumber = accountnumber;
            this.Depositfunds = depositfunds;
            this.Withdrawfuds = withdrawfunds;
        }

            public virtual decimal GetAccountBalance()
        {
            return this.AccountBalance;
        }

        public virtual decimal WithdrawFunds()
        {
            return AccountBalance - Withdrawfuds;
        }


    }

}

