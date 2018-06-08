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
            double newDepBal;
            double newWithdrawalBal;
            int depositResp;
            string exitResp;

            Checking checking = new Checking(65237, 5000, 15);
            Savings savings = new Savings(65238, 2500, 10);

            Client pete = new Client("pete", "1234 WCCI Street", "440 123 4567");

            Console.WriteLine("Welcome to the Bank of We Can Code It. Would you like to manage your accounts?");
            Console.WriteLine("YES / EXIT");
            exitResp = Console.ReadLine().ToLower();

            while (exitResp.Equals("yes"))
            {
                Console.WriteLine("Press 1 to manage checking account");
                Console.WriteLine("Press 2 to manage savings account");
                userResp = int.Parse(Console.ReadLine());
                savings.AddInterest();
                checking.AddInterest();

                if (userResp == 1)
                    checking.AddInterest();
                { Console.WriteLine("Current checking account balance is: $" + (checking.GetBalance() /*+ checking.Interest)*/)); }
                if (userResp == 2)
                { Console.WriteLine("Current savings account balance is: $" + (savings.GetBalance() + savings.Interest)); }

                Console.WriteLine("Press 1 to deposit to checking");
                Console.WriteLine("Press 2 to deposit to savings");
                depositResp = int.Parse(Console.ReadLine());
                savings.AddInterest();
                checking.AddInterest();

                if (userResp == 1)
                {
                    Console.WriteLine("How much money would you like to deposit?");
                    Console.Write("$");
                    depositAmt = double.Parse(Console.ReadLine());
                    newDepBal = checking.GetDeposit(depositAmt);
                    savings.AddInterest();
                    checking.AddInterest();
                    Console.WriteLine("Your new checking account balance is: $" + (checking.GetDeposit(depositAmt)));

                    Console.WriteLine("How much money would you like to withdrawal?");
                    Console.Write("$");
                    withdrawalAmt = double.Parse(Console.ReadLine());
                    savings.AddInterest();
                    checking.AddInterest();
                    Console.WriteLine("Your new checking account balance is: $" +checking.GetWithdrawal(withdrawalAmt - newDepBal));
                }
                if (userResp == 2)
                {
                    Console.WriteLine("How much money would you like to deposit?");
                    Console.Write("$");
                    depositAmt = double.Parse(Console.ReadLine());
                    newWithdrawalBal = savings.GetDeposit(depositAmt);
                    savings.AddInterest();
                    checking.AddInterest();
                    Console.WriteLine("Your new savings account balance is: $" + savings.GetDeposit(depositAmt));

                    Console.WriteLine("How much money would you like to withdrawal?");
                    Console.Write("$");
                    withdrawalAmt = double.Parse(Console.ReadLine());
                    savings.AddInterest();
                    checking.AddInterest();
                    Console.WriteLine("Your new savings account balance is: $" + savings.GetWithdrawal(withdrawalAmt - newWithdrawalBal));
                }

                Console.WriteLine("Would you like to manage your accounts again?");
                exitResp = Console.ReadLine().ToLower();
                savings.AddInterest();
                checking.AddInterest();
            }
            while (exitResp.Equals("exit"))
            { Console.WriteLine("Have a good day."); break; }
        }
    }
}

