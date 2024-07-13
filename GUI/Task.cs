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
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GUI
{
    public partial class Task : Form
    {
        string userID = UserProperties.UserId;
        string ProjectID = ProjectPropertise.ProjectId;
        string id_project = "PRJ-0011";
        public Task()
        {
            InitializeComponent();
        }

        private void Task_Load(object sender, EventArgs e)
        {
            BSHOME sHOME = new BSHOME();
            List<Tasks> task = new List<Tasks>();
            Employyees employyee = sHOME.GetEml(userID);
            task = sHOME.GetTask(ProjectID);
            dataGridView1.DataSource = task;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            BSHOME sHOME = new BSHOME();
            List<Tasks> task = new List<Tasks>();
            task = sHOME.GetTask(ProjectID);
            dataGridView1.DataSource = task;
        }
    }
}
