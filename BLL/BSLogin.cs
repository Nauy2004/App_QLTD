using DOT;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class BSLogin
    {
        
       
        public string CheckLogic(Users user)
        { 
            // Kết nối đến cơ sở dữ liệu và gọi thủ tục lưu trữ
            using (SqlConnection connection = ConnectDB.Connect())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SP_Login", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    // Tài khoản và mật khẩu hợp lệ
                    return "success";
                }
                else
                {
                    // Tài khoản hoặc mật khẩu không hợp lệ
                    return "failed";
                }
            }
        }



    }
}
