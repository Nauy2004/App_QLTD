using DOT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class UserAccess
    {
        public class TaiKhoanAcess : ConnectDB
        {
            public string CheckLogic(Users user)
            {
                string info = CheckLogic(user);
                return info;
            }
        }
    }
}
