using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    class Client
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Client(string Name, string Address, string PhoneNumber)
        {
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }

        public abstract class AddAccount
        {

        }
    }
}
