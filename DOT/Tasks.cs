using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    public class Tasks
    {
        public string TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DuaDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public int EstiMatedEffort { get; set; }

        public override string ToString()
        {
            return this.TaskID + "--" + TaskName + "--" + TaskDescription + "--" + DuaDate + "--" + Status + "--" + Priority + "--" + EstiMatedEffort;
        }
    }
}
