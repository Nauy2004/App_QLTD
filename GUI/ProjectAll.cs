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

namespace GUI
{
    public partial class ProjectAll : Form
    {
        string userID = UserProperties.UserId;
        public ProjectAll()
        {
            InitializeComponent();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjectAll_Load(object sender, EventArgs e)
        {
            BSHOME sHOME = new BSHOME();
            Employyees employyee = sHOME.GetEml(userID);
            showProject(employyee.EmployeeID);
        }

        private void listViewProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProject.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewProject.SelectedItems[0];
                string projectName = selectedItem.Text;
                guna2TextBox1.Text = projectName;
            }
        }

            public void showProject(string id)
            {
            BSHOME bshome = new BSHOME();
            List<Project> ds = bshome.GetProjects(id);
            listViewProject.Items.Clear();
            foreach (Project s in ds)
            {
                ListViewItem item = new ListViewItem(s.ProjectID);
                item.SubItems.Add(s.ProjectName);
                item.SubItems.Add(s.ProjectDescription.ToString());
                item.SubItems.Add(s.StartDate.ToString());
                item.SubItems.Add(s.EndDate.ToString());
                listViewProject.Items.Add(item);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            BSHOME bshome = new BSHOME();
            string text = guna2TextBox1.Text;
            List<Project> ds = bshome.sreachProjects(text);
            listViewProject.Items.Clear();
            foreach (Project s in ds)
            {
                ListViewItem item = new ListViewItem(s.ProjectID);
                item.SubItems.Add(s.ProjectName);
                item.SubItems.Add(s.ProjectDescription.ToString());
                item.SubItems.Add(s.StartDate.ToString());
                item.SubItems.Add(s.EndDate.ToString());
                listViewProject.Items.Add(item);
            }
            guna2TextBox1.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BSHOME sHOME = new BSHOME();
            Employyees employyee = sHOME.GetEml(userID);
            showProject(employyee.EmployeeID);
        }

        private void guna2TextBox1_TextClick(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (panel1_update.Visible == false)
            {
                panel1_update.Visible = true;
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            if (panel1_update.Visible == true)
            {
                panel1_update.Visible = false;
            }
        }

        private void btn_create_project_Click(object sender, EventArgs e)
        {
            if (panel1_update.Visible == false)
            {
                panel1_update.Visible = true;
            }
        }

        private void listViewProject_DoubleClick(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string isProjectSelect = guna2TextBox1.Text;
            BSHOME bshome = new BSHOME();
            Employyees employyee = bshome.GetEml(userID);
            List<UsersProject> ds = bshome.UserProjects(employyee.EmployeeID);
            bool projectDeleted = false;

            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].role.ToUpper() == "ADMIN" && ds[i].project_id == isProjectSelect)
                {
                    bshome.DeleteProject(isProjectSelect);
                    projectDeleted = true;
                    break;
                }
            }

            // User Feedback
            if (projectDeleted)
            {
                MessageBox.Show("Project deleted successfully.");
            }
            else
            {
                MessageBox.Show("You don't have permission to delete this project or the project ID might be incorrect.");
            }
        }
    }
}
