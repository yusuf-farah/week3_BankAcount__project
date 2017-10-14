using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_BankAcount_project
{
    class clientAccount
    {   // this code bellow shows the fields of the clientAccount
        private string name;
        private decimal balance;
        private int  accountNumber;
        private decimal withdrawMoney;
        private decimal depositfunds;
        // bellow are my properties
        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public decimal Balance
        {
            get { return this.Balance; }
            set { this.Balance = value;}
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
          
                public decimal DepositMoney

        {
            get { return this.depositfunds; }
            set { this.depositfunds = value; }
        }
         
        //bellow code is my constructors 
        public clientAccount(string name ,decimal balance, int accountnumber)
        {
            this.Name = name;
            this.Balance = balance;
            this.AccountNumber = accountNumber;
        }
        // here is method

        public virtual string GetInfo()
            {  
             return this.name+" "+ this.balance +" " + this.accountNumber+" " +withdrawMoney+ " " + depositfunds;
            }
            
      
            




    }
}
