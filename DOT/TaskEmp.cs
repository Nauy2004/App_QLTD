using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    public class TaskEmp
    {
        public string TaskID { get; set; }
        public string TaskName { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeRole { get; set; }

        public override string ToString()
        {
            return this.TaskID + "--" + TaskName + "--" + EmployeeName + "--" + EmployeeRole;
        }
    }
}
