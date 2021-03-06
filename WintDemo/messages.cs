﻿using System;
using System.Collections.Generic;

namespace WintDemo
{
    public static class Messages
    {
        public static void Greet()
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("Welcome to the WintDemo application");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
        }

        public static void ExplainBasicControls(DateTime timeStamp)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("These are the basic controls:");
            Console.WriteLine("Press 0 to display all controls.");
            Console.WriteLine("Press 1 to display account balance at " + timeStamp.ToShortDateString() + ", kl " + timeStamp.ToShortTimeString());
            Console.WriteLine("Press 2 to display sum of all deposits");
            Console.WriteLine("Press 3 to display sum of all withdrawals");
            Console.WriteLine("Press 4 to display the midnight report");
            Console.WriteLine("Press ESC to exit the application");
        }

        public static void DateBalance(DateTime timeStamp, decimal sum)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The accounts balance at " + timeStamp.ToShortDateString() + ", kl " + timeStamp.ToShortTimeString() + " is " + sum);
        }

        public static void DepositSum(decimal sum)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The total sum of all deposits are: " + sum);
        }

        public static void WithdrawalSum(decimal sum)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The total sum of all withdrawals are: " + sum);
        }

        public static void MindnightReport(Dictionary<DateTime, decimal> report)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            foreach (var r in report)
            {
                Console.WriteLine("The balance is " + r.Value + " at midnight on the " + r.Key.ToShortDateString());
            }
        }

    }
}
