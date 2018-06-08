using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    class Savings : Account
    {
        public double newWithdrawalBal { get; set; }

        public Savings(int acctNum, double balance, int interest)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
            this.Interest = interest;
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

        public override void Tick()
        {
            Interest--;
        }

    }
}
