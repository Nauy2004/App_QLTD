using DOT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class BSLogin
    {
        TaiKhoanAcess tkAccess = new TaiKhoanAcess();
        public string CheckLogic(Users user)
        {
            // Kiểm tra nghiệp vụ
            if (user.UserName == "")
            {
                return "requeid_taikhoan";
            }

            if (user.PasswordHash == "")
            {
                return "requeid_password";
            }

            string info = tkAccess.CheckLogic(user);
            return info;
        }
    }
}
