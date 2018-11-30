using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyManager.Model;
/* YOU MUST HAVE MYSQL REFERENCE */
using MySql.Data.MySqlClient;

namespace MoneyManager.Controller
{
    public class Database_Controller
    {
        // Singleton
        private Database_Controller self;

        private Database_Controller()
        {

        }

        public static Database_Controller GetSelf()
        {
            if (self == null)
            {
                self = new Database_Controller();
            }
            return self;
        }

        // Variables
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["local_dev"].ConnectionString;
        private MySqlConnection conn;
        private MySqlCommand comm;


        // INSERT
        /* ExecuteInsert function */
        /// <summary>
        /// Executes a query depending on the query string.
        /// </summary>
        public Exception ExecuteNonQuery(string query, List<MySqlParameter> parameters)
        {
            conn = new MySqlConnection();
            comm = new MySqlCommand(query, conn);
            
            foreach (MySqlParameter p in parameters)
            {
                comm.Parameters.AddWithValue(p.ParameterName, p.Value);
            }
            
            // Exception for comm.Prepare
            try
            {
                comm.Prepare();
            } catch (Exception Ex)
            {
                return new Exception("Could not prepare the MySql query. \n\nError description: " + Ex.Message);
            }

            // Exception for comm.ExecuteNonQuery
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                return new Exception("Failed to execute query to the database. \n\nError description: " + Ex.Message);
            }

            conn.Close();

            return null;
        }

        // SELECT
        /* ExecuteSelect function for Account  */
        /// <summary>
        /// Retrieves data from Account table and saves in a List.
        /// </summary>
        public List<Account> ExecuteReader_Account(string query, List<MySqlParameter> parameters)
        {
            conn = new MySqlConnection(connectionString);
            comm = new MySqlCommand(query, conn);

            if (parameters.Count() > 0)
            {
                foreach (MySqlParameter p in parameters)
                {
                    comm.Parameters.AddWithValue(p.ParameterName, p.Value);
                }
            }

            List<Account> result = new List<Account>();
            try
            {
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Account newAcc = new Account();
                        newAcc.idAccount = reader.GetInt32("idAccount");
                        newAcc.nameAccount = reader.GetString("nameAccount");
                        newAcc.balanceAmount = reader.GetDouble("balanceAccount");
                        newAcc.memoAccount = reader.GetString("memoAccount");
                        newAcc.accountType = Account_TypeDAO.GetAccountTypeById(reader.GetInt32("accountType"));
                        result.Add(newAcc);
                    }
                }
            } catch (Exception Ex)
            {
                throw new Exception("An error ocurred.Description: " + Ex.Message);
            } finally
            {
                conn.Close();
            }

            if (result.Count() > 0)
            {
                return result;
            }
            return null;
        }

        /* ExecuteSelect function for Account_type  */
        /// <summary>
        /// Retrieves data from Account_Type table and saves in a List.
        /// </summary>
        public List<Account_Type> ExecuteReader_Account_Type(string query, List<MySqlParameter> parameters)
        {
            conn = new MySqlConnection(connectionString);
            comm = new MySqlCommand(query, conn);

            if (parameters.Count() > 0)
            {
                foreach (MySqlParameter p in parameters)
                {
                    comm.Parameters.AddWithValue(p.ParameterName, p.Value);
                }
            }

            List<Account_Type> result = new List<Account_Type>();
            try
            {
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Account_Type newEntry = new Account_Type();
                        newEntry.idAccount_Type = AccountDAO.GetAccountById(reader.GetInt32("idAccount_Type"));
                        newEntry.nameAccount_Type = reader.GetString("nameAccount_Type");
                        result.Add(newEntry);
                    }
                }
            }
            catch (Exception Ex)
            {
                throw new Exception("An error ocurred.Description: " + Ex.Message);
            }
            finally
            {
                conn.Close();
            }

            if (result.Count() > 0)
            {
                return result;
            }
            return null;
        }


    }
}
