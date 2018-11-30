using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public interface IIncome
    {
        int idIncome { get; set; }
        string accountIncome { get; set; }
        Income_Category categoryIncome { get; set; }
        double amountIncom { get; set; }
        string memoIncome { get; set; }
        DateTime dateIncome { get; set; }
    }
}
