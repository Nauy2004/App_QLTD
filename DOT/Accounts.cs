using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    public class Accounts
    {
        public int AccountId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string EmployeeID { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            return this.AccountId + "--" + UserName + "--" + PasswordHash + "--" + EmployeeID + "--" + Role;
        }
    }
}
