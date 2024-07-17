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
            TextBoxStartProject.Text = DateTime.Now.ToString();
        }

        private void listViewProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectPropertise.ProjectId = "";
            if (listViewProject.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewProject.SelectedItems[0];

                // Assuming project name is in the first column (index 0)
                string projectName = selectedItem.SubItems[0].Text;
                guna2TextBox1.Text = projectName;

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
                    MessageBox.Show($"{ds.Count}");
                    
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

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
                Employyees employyee = projectBLL.GetEml(userID);
                List<UsersProject> ds = projectBLL.UserProjects(employyee.EmployeeID);

                projectBLL.AddProject(id, name, desc, startDate, endDate);

                if (projectBLL.checkUserProjectNull(ds, id))
                {
                    projectBLL.setProjectUser(employyee.EmployeeID, id, "admin");
                    MessageBox.Show("susecc");
                }
                else
                {
                    MessageBox.Show($"not susecc");
                }
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

        private void panel1_update_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
