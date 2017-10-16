using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_BankAcount_project
{
    class savingAccount:accounts

    { 
   


    public  savingAccount(decimal accountBalance, int accountnumber, decimal withdrawFunds, decimal depositfunds, decimal minimumAcctBalance)
    {

        this.AccountBalance = AccountBalance;
        this.AccountNumber = accountnumber;
        this.WithdrawMoney = withdrawFunds;
        this.Depositfunds = Depositfunds;
    }
            
        
        public virtual decimal GetAcountBalance()
        {
            return this.AccountBalance;
        }
       public virtual decimal GetWithdrawFunds()
        {
            return this.AccountBalance - this.WithdrawMoney;
        }
        public virtual decimal DepositFunds()
        {
            return this.AccountBalance + this.AccountBalance;
        }
    }
}
