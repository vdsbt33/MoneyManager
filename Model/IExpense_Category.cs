using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public interface IExpense_Category
    {
        int idCategory { get; set; }
        string nameCategory { get; set; }
    }
}
