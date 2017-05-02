using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WintDemo
{
    public class BankAccount
    {
        public decimal InitialBalance { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
    
}
