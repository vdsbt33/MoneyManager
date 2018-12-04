using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Model
{
    public class Account_Type : IAccount_Type
    {
        public int idAccount_Type { get; set; }
        public string nameAccount_Type { get; set; }

        public Account_Type(string nameAccount_Type)
        {
            this.nameAccount_Type = nameAccount_Type;
        }

        public Account_Type(int idAccount_Type, string nameAccount_Type)
        {
            this.idAccount_Type = idAccount_Type;
            this.nameAccount_Type = nameAccount_Type;
        }

    }
}
