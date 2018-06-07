using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    class Savings : Account
    {
        public Savings(int acctNum, double balance)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
        }

        public override double GetDeposit(double depositAmt)
        {
            double getDeposit;
            getDeposit = (SavingsBalance + depositAmt);
            return getDeposit;
        }

    }
}

