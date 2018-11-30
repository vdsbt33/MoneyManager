using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public class Expense_Category : IExpense_Category
    {
        public int idCategory { get; set; }
        public string nameCategory { get; set; }
    }
}
