using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    public class Employyees
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeRole { get; set; }

        public override string ToString()
        {
            return this.EmployeeID + "--" + EmployeeName + "--" + EmployeeEmail + "--" + EmployeeRole;
        }
    }
}
