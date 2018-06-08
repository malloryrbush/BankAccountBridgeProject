using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    class Checking : Account
    {
        public double newDepBal { get; set; }

        public Checking(int acctNum, double balance)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
        }

        public override double GetWithdrawal(double withdrawalAmt)
        {
            double getWithdrawal;
            getWithdrawal = (newDepBal - withdrawalAmt);
            return getWithdrawal;
        }
    }
}