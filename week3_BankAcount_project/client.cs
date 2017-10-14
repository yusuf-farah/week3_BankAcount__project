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
        private int phoneNumber;

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

        public string PhoneNumber
        {
            get { return this.PhoneNumber; }
            set { this.PhoneNumber = value; }
        }

        // constructors

        public client( string yusuf, string , string state)
        {
            this.Name = "yusuf";
            this.Address = "1345 cassady oh ";
            this.PhoneNumber = "6145672905";
        }

        public virtual string GetInfo()
        {
            return this.name + " " + this.address + " " + this.phoneNumber;
        }







    }
}
