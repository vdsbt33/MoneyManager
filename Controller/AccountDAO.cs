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
        private static AccountDAO self;

        private AccountDAO()
        {

        }

        public static AccountDAO GetSelf()
        {
            if (self == null)
            {
                self = new AccountDAO();
            }
            return self;
        }

        // Command Strings
        // INSERT
        private const string INSERT_ACCOUNT = "INSERT INTO account ( nameAccount, balanceAccount, memoAccount, accountType ) VALUES ( ?, ?, ?, ? );";
        // SELECT
        private const string SELECT_ACCOUNT_ALL = "SELECT idAccount, nameAccount, balanceAccount, memoAccount, accountType FROM account";
        private const string SELECT_ACCOUNT_BY_ID = "SELECT idAccount, nameAccount, balanceAccount, memoAccount, accountType FROM account WHERE idAccount = ?;";
        private const string SELECT_ACCOUNT_AND_TYPE_ALL = "SELECT acc.idAccount, acc.nameAccount, acc.balanceAccount, acc.memoAccount, typ.idAccount_Type, typ.nameAccount_Type FROM account acc JOIN account_Type typ ON typ.idAccount_Type = acc.accountType ORDER BY acc.idAccount ASC;";
        // DELETE
        private const string UPDATE_ACCOUNT = "UPDATE account set nameAccount = ?, balanceAccount = ?, memoAccount = ?, accountType = ? WHERE idAccount = ?;";
        // DELETE
        private const string DELETE_ACCOUNT = "DELETE FROM account WHERE idAccount = ?;";
        // COUNT
        private const string COUNT_ACCOUNT = "SELECT COUNT(ac.idAccount) as countAmount FROM account ac WHERE ac.accountType = ?;";
        
        // Variables

        // Insert
        /// <summary>
        /// Inserts an Account into database.
        /// </summary>
        /// <param name="account">Account variable, which stores its information.</param>
        /// <returns></returns>
        public Exception InsertAccount(Model.Account account)
        {
            // Parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("nameAccount", account.nameAccount));
            parameters.Add(new MySqlParameter("balanceAccount", account.balanceAccount));
            parameters.Add(new MySqlParameter("memoAccount", account.memoAccount));
            parameters.Add(new MySqlParameter("accountType", account.accountType.idAccount_Type));

            int val = Database_Controller.GetSelf().ExecuteNonQuery(INSERT_ACCOUNT, parameters);

            if (val >= 0)
            {
                account.idAccount = val;
                return null;
            } else
            {
                return new Exception("An error ocurred while trying to edit an account. (" + val + ")");
            }
            
        }

        // Select
        /// <summary>
        /// Gets all accounts and their Account_Type.
        /// </summary>
        /// <returns></returns>
        public List<Account> GetAllAccounts()
        {
            // Parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            
            List<Account> accounts = Database_Controller.GetSelf().ExecuteReader_Account(SELECT_ACCOUNT_AND_TYPE_ALL, parameters);
            if (accounts != null && accounts.Count() > 0)
            {
                return accounts;
            }
            return null;
        }

        /// <summary>
        /// Returns an Account with the entered ID, if one exists.
        /// </summary>
        /// <param name="id">ID of the target Account.</param>
        /// <returns></returns>
        public Account GetAccountById(int id)
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

        /// <summary>
        /// Updates an account on database.
        /// </summary>
        /// <param name="account">Variable with Account information, along with its ID.</param>
        public bool UpdateAccount(Account account)
        {
            // Parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("nameAccount", account.nameAccount));
            parameters.Add(new MySqlParameter("balanceAccount", account.balanceAccount));
            parameters.Add(new MySqlParameter("memoAccount", account.memoAccount));
            parameters.Add(new MySqlParameter("accountType", account.accountType.idAccount_Type));
            parameters.Add(new MySqlParameter("idAccount", account.idAccount));


            // Update database
            int val = Database_Controller.GetSelf().ExecuteNonQuery(UPDATE_ACCOUNT, parameters);

            if (val >= 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes the entered Account from database.
        /// </summary>
        /// <param name="account">Target Account to be removed.</param>
        /// <returns></returns>
        public bool RemoveAccount(Account account)
        {
            // Parameters
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("idAccount", account.idAccount));

            // Remove entry
            int val = Database_Controller.GetSelf().ExecuteNonQuery(DELETE_ACCOUNT, parameters);
            
            if (val >= 0)
            {
                return true;
            }
            return false;
        }

    }
}
