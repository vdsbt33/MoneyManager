using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public class Account : IAccount
    {
        public int idAccount { get; set; }
        public string nameAccount { get; set; }
        public double balanceAmount { get; set; }
        public string memoAccount { get; set; }
        public Account_Type accountType { get; set; }
    }
}
