using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public interface IExpense
    {
        int idExpense { get; set; }
        Account accountExpense { get; set; }
        Expense_Category categoryExpense { get; set; }
        double amountExpense { get; set; }
        string memoExpense { get; set; }
        DateTime dateExpense { get; set; }
    }
}
