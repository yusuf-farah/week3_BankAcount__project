using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_BankAcount_project
{
    class accounts
    { // this code bellow shows the fields of the clientAccount
        
        private decimal balance;
        private int accountNumber;
        private decimal withdrawMoney;
        private decimal depositfunds;
        // bellow are my properties
        
        public decimal Balance
        {
            get { return this.Balance; }
            set { this.Balance = value; }
        }



        public double AccountNumber
        {
            get { return this.AccountNumber; }
            set { this.AccountNumber = value; }
        }



        public decimal WithdrawMoney
        {
            get { return this.withdrawMoney; }
            set { this.withdrawMoney = value; }
        }

        public decimal Depositfunds

        {
            get { return this.depositfunds; }
            set { this.depositfunds = value; }
        }

        //bellow code is my constructors 
        public accounts(decimal balance, int accountNumber, decimal withdrawMoney, decimal depositMoney  )
        {
            this.Balance = balance;
            this.AccountNumber = accountNumber;
            this.WithdrawMoney = withdrawMoney;
            this.Depositfunds = depositfunds;
        }
       
    }
}
