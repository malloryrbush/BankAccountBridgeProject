using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            int userResp;
            double depositAmt;
            double withdrawalAmt;
            int depositResp;

            Checking checking = new Checking(65237, 5000);

            Savings savings = new Savings(65238, 2500);

            Console.WriteLine("Press 1 to view current checking balance");
            Console.WriteLine("Press 2 to view current savings balance");
            userResp = int.Parse(Console.ReadLine());

            if (userResp == 1)
            { Console.WriteLine(checking.GetBalance()); }
            if (userResp == 2)
            { Console.WriteLine(savings.GetBalance()); }

            Console.WriteLine("Press 1 to deposit to checking");
            Console.WriteLine("Press 2 to deposit to savings");
            depositResp = int.Parse(Console.ReadLine());

            if (userResp == 1)
            {
                Console.WriteLine("How much money would you like to deposit?");
                depositAmt = double.Parse(Console.ReadLine());
                Console.WriteLine(checking.GetDeposit(depositAmt));
            }
            if (userResp == 2)
            {
                Console.WriteLine("How much money would you like to deposit?");
                depositAmt = double.Parse(Console.ReadLine());
                Console.WriteLine(savings.GetDeposit(depositAmt));
            }

            //Console.WriteLine("How much money would you like to deposit?");
            //depositAmt = double.Parse(Console.ReadLine());
            //Console.WriteLine(checking.GetDeposit(depositAmt));

            //Console.WriteLine("How much money would you like to withdrawal?");
            //withdrawalAmt = double.Parse(Console.ReadLine());
            //Console.WriteLine(checking.GetWithdrawal(withdrawalAmt));
        }
        
    }
}
