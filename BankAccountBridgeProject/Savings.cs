using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    class Savings : Account
    {
        //double newWithdrawalBal;
        public double newWithdrawalBal { get; set; }

        public Savings(int acctNum, double balance)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
        }

        public override double GetDeposit(double depositAmt)
        {
            double getDeposit;
            getDeposit = (Balance + depositAmt);
            return getDeposit;
        }

        public override double GetWithdrawal(double withdrawalAmt)
        {
            double getWithdrawal;
            getWithdrawal = (newWithdrawalBal - withdrawalAmt);
            return getWithdrawal;
        }

    }
}
