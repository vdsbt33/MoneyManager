using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public class Expense : IExpense
    {
        public int idExpense { get; set; }
        public Account accountExpense { get; set; }
        public Expense_Category categoryExpense { get; set; }
        public double amountExpense { get; set; }
        public string memoExpense { get; set; }
        public DateTime dateExpense { get; set; }
    }
}
