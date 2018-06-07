using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    public abstract class Account
    {
        public int AcctNum { get; set; }
        public double Balance { get; set; }
        public double SavingsBalance { get; set; }
        public string TypeChecking { get; set; }
        public string TypeSavings { get; set; }
        public double Deposit { get; set; }

        public double GetBalance()
        {
            double getBalance;
            getBalance = Balance;
            return getBalance;
        }

        public virtual double GetDeposit(double depositAmt)
        {
            double getDeposit;
            getDeposit = (Balance + depositAmt);
            return getDeposit;
        }

        public double GetWithdrawal(double withdrawalAmt)
        {
            double getWithdrawal;
            getWithdrawal = (Balance - withdrawalAmt);
            return getWithdrawal;
        }
    }
}
