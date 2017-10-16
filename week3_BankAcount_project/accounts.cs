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
        private string  accountNumber; 
        private string accountType;
        // bellow are my properties

        public decimal AccountBalance
        {
            get { return this.accountbalance; }
            set { this.accountbalance = value; }
        }

        public string AccountNumber
        {
            get { return this.accountNumber; }  
        }  
     
        private string AccountType
        {
            get { return this.accountType; }
             
        }

        //bellow code is my constructors 
        public accounts(decimal accountbalance, string accountNumber, string accountType)
        {
            this.accountbalance = accountbalance;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
        }

        // bellow are my methods
        public virtual decimal depositfund(decimal amount)
        {
             this.accountbalance += amount;
            return this.accountbalance;
        }
        public virtual bool withdraw( decimal amount)
           
        {
            if(amount>this.accountbalance)
            {
                return false;
            }
            else
            {
                this.accountbalance = this.accountbalance - amount;
                return true;
            }
        }

        
    }
}
