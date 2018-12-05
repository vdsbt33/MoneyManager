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

        private Account_TypeDAO()
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

        // Command Strings
        // INSERT
        private const string INSERT_ACCOUNT_TYPE = "INSERT INTO account_type ( nameAccount_Type ) VALUES ( ? );";
        // SELECT
        private const string SELECT_ACCOUNT_TYPE_ALL = "SELECT idAccount_Type, nameAccount_Type FROM Account_Type ORDER BY idAccount_Type ASC;";
        private const string SELECT_ACCOUNT_TYPE_BY_ID = "SELECT idAccount_Type, nameAccount_Type WHERE idAccount_Type = ?;";
        // DELETE
        private const string UPDATE_ACCOUNT = "UPDATE account_type set nameAccount_Type = ? WHERE idAccount_Type = ?;";
        // DELETE
        private const string DELETE_ACCOUNT = "DELETE FROM account_type WHERE idAccount_Type = ?;";
        // COUNT
        private const string COUNT_ACCOUNT_TYPE = "SELECT COUNT(act.idAccount_Type) as countAmount FROM account ac JOIN account_type act ON ac.accountType = act.idAccount_Type WHERE ac.accountType = ?;";
        
        // Variables

        public Exception InsertAccount_Type(Account_Type account_type)
        {
            // Parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("nameAccount_Type", account_type.nameAccount_Type));

            int val = Database_Controller.GetSelf().ExecuteNonQuery(INSERT_ACCOUNT_TYPE, parameters);

            if (val >= 0)
            {
                account_type.idAccount_Type = val;
                return null;
            }
            else
            {
                return new Exception("An error ocurred while trying to add the Account Type (" + val + ")");
            }
        }

        /// <summary>
        /// Gets an account type by its id
        /// </summary>
        public Account_Type GetAccountTypeById(int id)
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

        /// <summary>
        /// Gets all account types
        /// </summary>
        public List<Account_Type> GetAccountAll()
        {
            // Parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            List<Account_Type> result = Database_Controller.GetSelf().ExecuteReader_Account_Type(SELECT_ACCOUNT_TYPE_ALL, parameters);
            return result;

        }

        /// <summary>
        /// Gets the count of Accounts with the selected Account Type in the database.
        /// </summary>
        /// <returns></returns>
        public int GetAccount_TypeCount(Account_Type accountType)
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("accountType", accountType.idAccount_Type));
            return Database_Controller.GetSelf().ExecuteCount(COUNT_ACCOUNT_TYPE, parameters);
        }

        /// <summary>
        /// Removes the entered Account Type
        /// </summary>
        /// <param name="accountType"></param>
        /// <returns></returns>
        public bool RemoveAccount_Type(Account_Type accountType)
        {
            if (GetAccount_TypeCount(accountType) > 0)
            {
                return false;
            } else
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("idAccount_Type", accountType.idAccount_Type));

                int val = Database_Controller.GetSelf().ExecuteNonQuery(DELETE_ACCOUNT, parameters);

                if (val >= 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool UpdateAccount_Type(Account_Type accountType)
        {
            // Parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("nameAccount_Type", accountType.nameAccount_Type));
            parameters.Add(new MySqlParameter("idAccount_Type", accountType.idAccount_Type));

            int val = Database_Controller.GetSelf().ExecuteNonQuery(UPDATE_ACCOUNT, parameters);
            
            if (val >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
