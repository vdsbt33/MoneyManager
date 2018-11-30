using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public class Income : IIncome
    {
        public int idIncome { get; set; }
        public string accountIncome { get; set; }
        public Income_Category categoryIncome { get; set; }
        public double amountIncom { get; set; }
        public string memoIncome { get; set; }
        public DateTime dateIncome { get; set; }
    }
}
