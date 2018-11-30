using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using MoneyManager.Model;

namespace MoneyManager.Controller
{
    public class AccountDAO
    {
        // Singleton
        private AccountDAO self;

        public AccountDAO()
        {

        }

        public AccountDAO GetSelf()
        {
            if (self == null)
            {
                self = new AccountDAO();
            }
            return self;
        }

        // Connection Strings
        private const string SELECT_ACCOUNT_ALL = "SELECT idAccount, nameAccount, balanceAccount, memoAccount, accountType FROM Account";
        private const string SELECT_ACCOUNT_BY_ID = "SELECT idAccount, nameAccount, balanceAccount, memoAccount, accountType FROM Account WHERE idAccount = ?;";

        // Variables

        // Select
        public List<Account> GetAllAccounts()
        {
            return;
        }

        public static Account GetAccountById(int id)
        {
            // Parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("idAccount", id));

            List<Account> accounts = Database_Controller.GetSelf().ExecuteReader_Account(SELECT_ACCOUNT_BY_ID, parameters);
            if (accounts.Count() == 1)
            {
                return accounts[0];
            }
            return null;
        }
    }
}
