using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    public class Users
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            return this.UserID + "--" + UserName + "--" + PasswordHash;
        }
    }
}
