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
        private static Database_Controller self;

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
        public int ExecuteNonQuery(string query, List<MySqlParameter> parameters)
        {
            conn = new MySqlConnection(connectionString);
            comm = new MySqlCommand(query, conn);
            
            foreach (MySqlParameter p in parameters)
            {
                comm.Parameters.AddWithValue(p.ParameterName, p.Value);
            }
            
            // Exception for comm.Prepare
            try
            {
                conn.Open();
                comm.Prepare();
            } catch (Exception Ex)
            {
                return -1;
            }

            // Exception for comm.ExecuteNonQuery
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                return -2;
            }

            conn.Close();
            return (int) comm.LastInsertedId;
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
                conn.Open();

                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model.Account newAcc = new Model.Account();
                        newAcc.idAccount = reader.GetInt32("idAccount");
                        newAcc.nameAccount = reader.GetString("nameAccount");
                        newAcc.balanceAccount = reader.GetDouble("balanceAccount");
                        newAcc.memoAccount = reader.GetString("memoAccount");
                        newAcc.accountType = new Model.Account_Type(reader.GetInt32("idAccount_Type"), reader.GetString("nameAccount_Type"));
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
                conn.Open();
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Account_Type newEntry = new Account_Type(reader.GetInt32("idAccount_Type"), reader.GetString("nameAccount_Type"));
                        result.Add(newEntry);
                    }
                }

                if (result.Count() > 0)
                {
                    return result;
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
            return null;
        }


    }
}
