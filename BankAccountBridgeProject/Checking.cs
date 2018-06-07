using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    class Checking : Account 
    {
        public Checking(int acctNum, double balance)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
        }
    }
}
