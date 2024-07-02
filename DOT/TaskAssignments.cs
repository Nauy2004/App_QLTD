using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    internal class TaskAssignments
    {
        public string TaskID { get; set; }
        public string EmployeeID { get; set; }

        public override string ToString()
        {
            return this.TaskID + "--" + EmployeeID;
        }
    }
}
