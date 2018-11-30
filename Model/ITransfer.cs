using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public interface ITransfer
    {
        int idTransfer { get; set; }
        Account fromAccountTransfer { get; set; }
        Account toAccountTransfer { get; set; }
        double amountTransfer { get; set; }
        DateTime dateTransfer { get; set; }
        string memoTransfer { get; set; }
    }
}
