using DOT;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class Database_Login
    {
        public static string Login(Users user)
        {
            string userlogin = null;
            try
            {
                SqlConnection conn = ConnectDB.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_Login", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", user.UserName);
                cmd.Parameters.AddWithValue("@Password", user.PasswordHash);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.UserID = reader.GetString(0); // Đọc UserID
                        userlogin = user.UserID; // Trả về UserID
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
            return userlogin;
        }
    }
}

