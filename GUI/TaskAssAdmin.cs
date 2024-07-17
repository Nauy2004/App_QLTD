using BLL;
using DOT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TaskAssAdmin : Form
    {
        public string idTask;
        public TaskAssAdmin()
        {
            InitializeComponent();
        }

        private void listViewEmpTask_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TaskAssAdmin_Load(object sender, EventArgs e)
        {
            showListTask();
            showAllComment();
        }
        private void showAllComment()
        {
            BStaskAdmin bStaskAdmin = new BStaskAdmin();
            List<TaskComments> taskC = new List<TaskComments>();
            taskC = bStaskAdmin.GetCommentByID(idTask);
            foreach (TaskComments taskComment in taskC)
            {
                richTextBoxComment.AppendText(taskComment.ToString());
                richTextBoxComment.AppendText("\n");
            }
        }
        private void showListTask()
        {
            BStaskAdmin bStaskAdmin = new BStaskAdmin();
            List<TaskEmp> task = new List<TaskEmp>();
            task = bStaskAdmin.GetTaskAssignmentsByID(idTask); 
            listViewEmpTask.Items.Clear();
            foreach (TaskEmp s in task)
            {
                ListViewItem item = new ListViewItem(s.TaskID.ToString());
                item.SubItems.Add(s.TaskName.ToString());
                item.SubItems.Add(s.EmployeeName.ToString());
                item.SubItems.Add(s.EmployeeRole.ToString());
                listViewEmpTask.Items.Add(item);
            }
        }
    }
}
