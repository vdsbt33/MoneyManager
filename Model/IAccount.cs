using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public interface IAccount
    {
        int idAccount { get; set; }
        string nameAccount { get; set; }
        double balanceAmount { get; set; }
        string memoAccount { get; set; }
        Account_Type accountType { get; set; }
    }
}
