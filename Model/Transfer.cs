using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public class Transfer : ITransfer
    {
        public int idTransfer { get; set; }
        public Account fromAccountTransfer { get; set; }
        public Account toAccountTransfer { get; set; }
        public double amountTransfer { get; set; }
        public DateTime dateTransfer { get; set; }
        public string memoTransfer { get; set; }
    }
}
