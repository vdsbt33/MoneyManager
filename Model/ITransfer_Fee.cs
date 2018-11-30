using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public interface ITransfer_Fee
    {
        int idTransfer_Fee { get; set; }
        double amountTransfer_Fee { get; set; }
    }
}
