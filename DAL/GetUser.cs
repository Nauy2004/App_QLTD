using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT;

namespace DAL
{
    public class GetDataUser
    {
        public Users GetUserById(string userId)
        {
            Users user = null;
            try
            {
                using (SqlConnection conn = ConnectDB.Connect()) // Use using for automatic resource disposal
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SP_getInfoUser", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", userId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.Read()) // Assuming a single user per ID
                        {
                            user = new Users(); // Create a new User object
                            user.UserID = reader.GetString(0);
                            user.UserName = reader.GetString(1);
                            user.PasswordHash = reader.GetString(2);
                        }
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions appropriately (logging, error messages)
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }

            return user;
        }

        public String GetRoleUser(string roleId)
        {
            string userRole = null;
            try
            {
                SqlConnection conn = ConnectDB.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_getRoleLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", roleId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        userRole = reader.GetString(0);
                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi SQL
                throw new Exception("Lỗi khi đăng nhập: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khác
                throw new Exception("Lỗi không xác định: " + ex.Message);
            }
            return userRole;
        }

        public Employyees GetEmployyees(string userId)
        {
            Employyees Empl = null;
            try
            {
                using (SqlConnection conn = ConnectDB.Connect()) // Use using for automatic resource disposal
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SP_getInfoEmpl", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", userId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.Read()) // Assuming a single user per ID
                        {
                            Empl = new Employyees(); // Create a new User object
                            Empl.EmployeeID = reader.GetString(0);
                            Empl.EmployeeName = reader.GetString(1);
                            Empl.EmployeeEmail = reader.GetString(2);
                            Empl.EmployeeRole = reader.GetString(3);
                        }
                    }

                    reader.Close();
                }
            }
            catch { }
            return Empl;
        }
    }
}
