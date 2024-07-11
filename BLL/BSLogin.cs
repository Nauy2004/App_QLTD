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
            string userId = null;
            try
            {
                userId = Database_Login.Login(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trong quá trình xử lý đăng nhập: " + ex.Message);
            }
            return userId;
        }
    }
}
