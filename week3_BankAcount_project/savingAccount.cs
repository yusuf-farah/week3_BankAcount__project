using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_BankAcount_project
{
    class savingAccount : accounts

    {
        private const decimal minimumBalance = 200;


        public savingAccount(decimal acountbalance, string accountNumber) : base(acountbalance, accountNumber, "saving")
        {

        }

       public override bool withdraw(decimal amount)
        {   
            if(this.AccountBalance>minimumBalance+amount)
            {
                return base.withdraw(amount);
            }
           else
            {
                return false;
            }

        }
       
    }
            
        
        
    }
