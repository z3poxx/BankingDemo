using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WintDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runDemoApp = true;
            DateTime timeStamp = new DateTime(2015, 09, 04, 12, 00, 00);

            var _bank = new BankAccountRepo();

            Messages.Greet(); 
            Messages.ExplainBasicControls(timeStamp);

            while (runDemoApp)
            {
                ConsoleKeyInfo consoleInput = Console.ReadKey();

                // controls
                if (consoleInput.KeyChar == '0')                
                    Messages.ExplainBasicControls(timeStamp);
                
                                
                // display balance @timeStamp
                if (consoleInput.KeyChar == '1')                
                    Messages.DateBalance(timeStamp, _bank.GetAccountBalance(timeStamp));
                

                // display sum of all deposits
                if (consoleInput.KeyChar == '2')                
                    Messages.DepositSum(_bank.GetSumOfDeposits());
                

                // display sum of all whidrawals
                if (consoleInput.KeyChar == '3')                
                    Messages.WithdrawalSum(_bank.GetSumOfWithdrawals());
                

                // display the midnight balances
                if (consoleInput.KeyChar == '4')                
                    Messages.TempMSG();
                
            }

        }
    }
}
