using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_BankAcount_project
{
    class client
    {
        // fields

        private string name;
        private string address;
        private string phoneNumber;
        private savingAccount saving; 
        private checkingAccount checking;
        // properties

        public string Name
        {
            get { return this.Name; }
            set { this.name = value; }
        }


        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string  PhoneNumber
        {
            get { return this.PhoneNumber; }
            set { this.PhoneNumber = value; }
        }

        public  checkingAccount Checking
        {  get { return this.checking; }
            set { this.checking= value; }

        }

        public savingAccount Saving
        {
            get { return this.saving; }
            set { this.saving = value; }
        }

        // constructors

        public client( string name, string address, string phone, savingAccount saving, checkingAccount checking)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phone;
            this.Checking = checking;
            this.Saving = saving;
        }

        public virtual string GetInfo()
        {
            return this.name + " " + this.address + " " + this.phoneNumber+". "+this.saving.AccountNumber+ ". " + this.checking.AccountNumber;
        }


        




    }
}
