using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DOT;

namespace DAL
{
    public class DAL_Account
    {

        private SqlConnection conn = ConnectDB.Connect();

        public List<Accounts> GetAllAccounts()
        {
            List<Accounts> accounts = new List<Accounts>();
            try
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllAccounts", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        accounts.Add(new Accounts
                        {
                            AccountId = (char)reader["AccountId"],
                            UserName = reader["UserName"].ToString(),
                            PasswordHash = reader["Password"].ToString(),
                            EmployeeID = reader["EmployeeID"].ToString(),
                            Role = reader["Role"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return accounts;
        }

        public void AddAccount(Accounts account)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("SP_AddAccount", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", account.UserName);
                    command.Parameters.AddWithValue("@Password", account.PasswordHash);
                    command.Parameters.AddWithValue("@Role", account.Role);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void UpdateAccount(Accounts account)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateAccount", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", account.AccountId);
                    command.Parameters.AddWithValue("@UserName", account.UserName);
                    command.Parameters.AddWithValue("@Password", account.PasswordHash);
                    command.Parameters.AddWithValue("@EmployeeID", account.EmployeeID);
                    command.Parameters.AddWithValue("@Role", account.Role);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void DeleteAccount(char accountId)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("SP_DeleteAccount", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", accountId);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public List<Accounts> SearchAccounts(string keyword)
        {
            List<Accounts> accounts = new List<Accounts>();
            try
            {
                using (SqlCommand command = new SqlCommand("SearchAccounts", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        accounts.Add(new Accounts
                        {
                            AccountId = (char)reader["AccountId"],
                            UserName = reader["UserName"].ToString(),
                            PasswordHash = reader["Password"].ToString(),
                            EmployeeID = reader["EmployeeID"].ToString(),
                            Role = reader["Role"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return accounts;
        }

    }
}