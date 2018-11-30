using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public class Transfer_Fee : ITransfer_Fee
    {
        public int idTransfer_Fee { get; set; }
        public double amountTransfer_Fee { get; set; }
    }
}
