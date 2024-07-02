using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    internal class TaskComments
    {
        public string CommentID { get; set; }
        public string CommentText { get; set; }
        public string CommentedBy { get; set; }
        public string TaskID { get; set; }
        public DateTime CommentedOn { get; set; }

        public override string ToString()
        {
            return this.CommentID + "--" + CommentText + "--" + CommentedBy + "--" + TaskID + "--" + CommentedOn;
        }
    }
}
