using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WintDemo
{
    public class BankAccountRepo
    {
        public BankAccountRepo()
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
                .Where(t => t.Amount >= 0)
                .Select(t => t.Amount)
                .Sum();
        }

        public decimal GetSumOfWithdrawals()
        {
            return Account.Transactions
                .Where(t => t.Amount <= 0)
                .Select(t => t.Amount)
                .Sum();
        }

    }
}
