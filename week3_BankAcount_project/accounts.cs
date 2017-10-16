using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_BankAcount_project
{
    class accounts
    { // this code bellow shows the fields of the clientAccount

        private decimal accountbalance;
        private int accountNumber;
        private decimal withdrawfunds;
        private decimal depositfunds;
        private bool accountType;
        // bellow are my properties

        public decimal AccountBalance
        {
            get { return this.AccountBalance; }
            set { this.AccountBalance = value; }
        }



        public int AccountNumber
        {
            get { return this.AccountNumber; }
            set { this.AccountNumber = value; }
        }



        public decimal Withdrawfuds
        {
            get { return this.withdrawfunds; }
            set { this.withdrawfunds = value; }
        }

        public decimal Depositfunds

        {
            get { return this.depositfunds; }
            set { this.depositfunds = value; }
        }
        private bool AcountType
        {
            get { return this.AcountType; }
            set { this.AcountType = value; }
        }


        //bellow code is my constructors 
        public accounts(decimal acountbalance, int accountNumber, decimal withdrawFunds, decimal depositFunds, bool accoutType)
        {
            this.AccountBalance = accountbalance;
            this.AccountNumber = accountNumber;
            this.withdrawfunds = withdrawFunds;
            this.Depositfunds = depositfunds;
            this.AcountType = accountType;
        }


        public virtual bool GetAccountType()
        {
            return this.AcountType;

        }
        public virtual int acountNumber()
        {
            return this.AccountNumber;
        }
    }
}
