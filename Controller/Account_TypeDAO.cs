using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using MoneyManager.Model;

namespace MoneyManager.Controller
{
    public class Account_TypeDAO
    {
        // Singleton
        private static Account_TypeDAO self;

        public Account_TypeDAO()
        {

        }

        public static Account_TypeDAO GetSelf()
        {
            if (self == null)
            {
                self = new Account_TypeDAO();
            }
            return self;
        }

        // Connection Strings
        private const string SELECT_ACCOUNT_TYPE_ALL = "SELECT idAccount, nameAccount, balanceAccount, memoAccount, accountType FROM Account";
        private const string SELECT_ACCOUNT_TYPE_BY_ID = "SELECT idAccount_Type, nameAccount_Type WHERE idAccount_Type = ?;";
        
        // Variables

        public static Account_Type GetAccountTypeById(int id)
        {
            // Parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("idAccount_Type", id));
            
            List<Account_Type> result = Database_Controller.GetSelf().ExecuteReader_Account_Type(SELECT_ACCOUNT_TYPE_BY_ID, parameters);
            if (result.Count() == 1)
            {
                return result[0];
            }
            return null;
        }
    }
}
