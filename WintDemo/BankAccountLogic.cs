using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WintDemo
{
    public class BankAccountLogic
    {
        public BankAccountLogic()
        {
            _Account = LoadData();
        }

        private BankAccount _Account { get; set; }

        public BankAccount Account
        {
            get { return _Account; }
        }

        private BankAccount LoadData()
        {
            var result = new BankAccount();
            var path = "../../bankaccount.json";
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<BankAccount>(json);
            }
            return result;            
        }

        public decimal GetAccountBalance(DateTime timeStamp)
        {
            var balanceChange = Account.Transactions
                .Where(t => t.Timestamp <= timeStamp)
                .Select(t => t.Amount)
                .Sum();

            return Account.InitialBalance + balanceChange;
        }

        public decimal GetSumOfDeposits()
        {
            return Account.Transactions
                .Where(t => t.Amount > 0)
                .Select(t => t.Amount)
                .Sum();
        }

        public decimal GetSumOfWithdrawals()
        {
            return Account.Transactions
                .Where(t => t.Amount < 0)
                .Select(t => t.Amount)
                .Sum();
        }

        public Dictionary<DateTime, decimal> GetMindnightReport()
        {
            var currentBalance = Account.InitialBalance;
            var result = new Dictionary<DateTime, decimal>();

            var midnightReports = Account.Transactions
                .GroupBy(t => t.Timestamp.Date)
                .Select(g => new { TimeStamp = g.Key, Value = g.Sum(s => s.Amount) });

            foreach (var report in midnightReports)
            {
                currentBalance += report.Value;
                result.Add(report.TimeStamp, currentBalance);
            }

            return result;
        }

    }
}