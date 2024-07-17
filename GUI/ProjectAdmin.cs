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
    public partial class ProjectAdmin : Form
    {
        string userID = UserProperties.UserId;
        public ProjectAdmin()
        {
            InitializeComponent();
        }

        private void ProjectAdmin_Load(object sender, EventArgs e)
        {
            showProject();
            showComboIndex();
            TextBoxStartProject.Text = DateTime.Now.ToString();
        }
        private void listViewProject_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProjectPropertise.ProjectId = "";
            if (listViewProject.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewProject.SelectedItems[0];

                // Assuming project name is in the first column (index 0)
                string projectName = selectedItem.SubItems[0].Text;
                guna2TextBox1.Text = projectName;
                LSidProject.Text = projectName;

                // Assuming project ID is in the second column (index 1)
                string projectID = selectedItem.SubItems[0].Text;
                textboxIDproject.Text = projectID;

                // Assuming remaining details are in subsequent columns (adjust indices as needed)
                TextBoxNameProject.Text = selectedItem.SubItems[1].Text;
                TextBoxDescProject.Text = selectedItem.SubItems[2].Text;
                TextBoxStartProject.Text = selectedItem.SubItems[3].Text;
                textBoxProjectEnd.Text = selectedItem.SubItems[4].Text;
                ProjectPropertise.ProjectId = projectID.Trim();
            }
        }
        //search Project
        private void guna2Button4_Click_1(object sender, EventArgs e)
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
        //refe
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            showProject();
        }
        public void showProject()
        {
            BSProjectAdmin bSProjectAdmin = new BSProjectAdmin();
            List<Project> ds = bSProjectAdmin.GetProjectsAll();
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


        //update Project
        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            string id = textboxIDproject.Text;
            string name = TextBoxNameProject.Text;
            string desc = TextBoxDescProject.Text;
            DateTime startDate = DateTime.Parse(TextBoxStartProject.Text);
            DateTime endDate = DateTime.Parse(textBoxProjectEnd.Text);

            try
            {
                BSHOME projectBLL = new BSHOME();
                projectBLL.UPProject(id, name, desc, startDate, endDate);
                MessageBox.Show("Project Update successfully!");
                clearTextBox();
                panel1_update.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating project: " + ex.Message);
            }
        }

        //create project
        private void CreateBtnProject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxIDproject.Text) ||
                    string.IsNullOrEmpty(TextBoxNameProject.Text) ||
                    string.IsNullOrEmpty(TextBoxDescProject.Text))
            {
                MessageBox.Show("Please fill in all project details!");
                return;
            }
            string id = textboxIDproject.Text;
            string name = TextBoxNameProject.Text;
            string desc = TextBoxDescProject.Text;
            DateTime startDate = DateTime.Parse(TextBoxStartProject.Text);
            DateTime endDate = DateTime.Parse(textBoxProjectEnd.Text);

            try
            {
                BSHOME projectBLL = new BSHOME();
                projectBLL.AddProject(id, name, desc, startDate, endDate);
                MessageBox.Show("Project created successfully!");
                clearTextBox();
                panel1_update.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating project: " + ex.Message);
            }
        }

        private void clearTextBox()
        {
            textboxIDproject.Clear();
            TextBoxNameProject.Clear();
            TextBoxDescProject.Clear();
            textBoxProjectEnd.Clear();
        }

        private void btn_create_project_Click(object sender, EventArgs e)
        {
            panel1_update.Visible=true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel1_update.Visible = true;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            panel1_update.Visible = false;
        }
        public void showComboIndex()
        {
            BSProjectAdmin bSProjectAdmin = new BSProjectAdmin();
            List<Employyees> ds = bSProjectAdmin.getEmpAll();
            ListIDemp.Items.Clear();
            foreach (Employyees s in ds)
            {
                ListIDemp.Items.Add(s.EmployeeID);
            };
        }
        private void ListIDemp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // thêm nhân viên vào dự án
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string idE = ListIDemp.SelectedItem.ToString();
            string idP = LSidProject.Text;
            string role;
            BSHOME projectBLL = new BSHOME();
            BSProjectAdmin bSProjectAdmin = new BSProjectAdmin();
            List<Employyees> ds = bSProjectAdmin.getEmpAll();
            List<UsersProject> ds1 = projectBLL.UserProjects(idE);
            if (bSProjectAdmin.checkUserProjectNull(ds1, idP))
            {
                bSProjectAdmin.setProjectUser(idE, idP, "user");
                MessageBox.Show("susecc");
            }
            else
            {
                MessageBox.Show($"not susecc");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            BSHOME projectBLL = new BSHOME();
            BSProjectAdmin bSProjectAdmin = new BSProjectAdmin(); 
            string idP = guna2TextBox1.Text;
            List<Tasks> ds = projectBLL.GetTask(idP);
            bSProjectAdmin.DeleteProject(idP, ds);
            showProject();
        }

        private void panel1_update_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
