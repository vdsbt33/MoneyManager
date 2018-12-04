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
        public double balanceAccount { get; set; }
        public string memoAccount { get; set; }
        public Account_Type accountType { get; set; }

        public Account()
        {

        }

        public Account(string nameAccount, Model.Account_Type accountType, double balanceAccount, string memoAccount)
        {
            this.nameAccount = nameAccount;
            this.accountType = accountType;
            this.balanceAccount = balanceAccount;
            this.memoAccount = memoAccount;
        }
    }
}
