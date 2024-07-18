using BLL;
using DOT;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace GUI
{
    public partial class TaskAdmin : Form
    {
        private string idTask = null;
        private string[] myArray = { "Cần làm", "Chưa bắt đầu", "Hoàn thiện", "Đang tiến hành" };

        public TaskAdmin()
        {
            InitializeComponent();
        }

        private void setComboBox()
        {
            foreach (var item in myArray)
            {
                guna2ComboBox1.Items.Add(item);
            }        
        }
        private void setComboBoxIDTask()
        {
            BStaskAdmin bStaskAdmin = new BStaskAdmin();
            List<Tasks> task = new List<Tasks>();
            task = bStaskAdmin.GetTasks();
            foreach (Tasks item in task)
            {
                ComboBoxIDTask.Items.Add(item.TaskID);
            }
        }
        private void setComboBoxIDEMP()
        {
            BStaskAdmin bStaskAdmin = new BStaskAdmin();
            List<Employyees> emp = new List<Employyees>();
            emp = bStaskAdmin.GetEMPS();
            foreach (Employyees item in emp)
            {
                ComboBoxIdEMP.Items.Add(item.EmployeeID);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                if (cell is DataGridViewButtonCell buttonCell)
                {
                    panel1_update.Visible = true;

                    int rowIndex = e.RowIndex;

                    // Retrieve data from the clicked row
                    string data1 = dataGridView1["IDTask", rowIndex].Value.ToString();
                    string data2 = dataGridView1["Column2", rowIndex].Value.ToString();
                    string data3 = dataGridView1["Column3", rowIndex].Value.ToString();
                    string data4 = dataGridView1["Column4", rowIndex].Value.ToString();
                    string data5 = dataGridView1["Column5", rowIndex].Value.ToString();
                    string data6 = dataGridView1["Column6", rowIndex].Value.ToString();
                    string data7 = dataGridView1["Column7", rowIndex].Value.ToString();
                    string data8 = dataGridView1["Column8", rowIndex].Value.ToString();

                    // Update TextBox with the data
                    guna2TextBox2.Text = data1;
                    textboxIDproject.Text = data8;
                    TextBoxNameProject.Text = data2;
                    TextBoxDescProject.Text = data3;
                    TextBoxStartProject.Text = data4;
                    textBoxProjectEnd.Text = data6;
                    guna2TextBox1.Text = data7;
                    for(int i  = 0; i < myArray.Length;i++)
                    {
                        if (myArray[i] == data5)
                        {
                            guna2ComboBox1.SelectedIndex = i;
                        }
                    }
                    
                }
            }
        }

        private void TaskAdmin_Load(object sender, EventArgs e)
        {
            setComboBox();
            setComboBoxIDEMP();
            setComboBoxIDTask();
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            BStaskAdmin bStaskAdmin = new BStaskAdmin();
            List<Tasks> task = new List<Tasks>();
            task = bStaskAdmin.GetTasks();
            dataGridView1.DataSource = task;
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            panel1_update.Visible = false;
        }

        private void labelendProject_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            BStaskAdmin bStaskAdmin = new BStaskAdmin();
            string taskName = TextBoxNameProject.Text;
            string desc = TextBoxDescProject.Text;
            DateTime dueDate = Convert.ToDateTime(TextBoxStartProject.Text);
            string Pro = textBoxProjectEnd.Text;
            string em = guna2TextBox1.Text;
            string status = guna2ComboBox1.Text;
            string id = guna2TextBox2.Text;
            try
            {
                bStaskAdmin.UPTask(id, taskName, desc, dueDate, status, Pro, em);
                MessageBox.Show("Update task Succes");
                panel1_update.Visible = false;
                loadDataGrid();
            }catch { throw; }
        }

        private void panel1_update_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ButtonADD_Click(object sender, EventArgs e)
        {
            panel1_update.Visible = true;
            guna2ButtonUpdate.Visible = false;
            guna2ButtonDelete.Visible = false;
            CreateBtnTask.Visible = true;

        }

        private void CreateBtnTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxIDproject.Text) ||
            string.IsNullOrEmpty(guna2TextBox2.Text) ||
            string.IsNullOrEmpty(TextBoxNameProject.Text) ||
            string.IsNullOrEmpty(TextBoxDescProject.Text) ||
            string.IsNullOrEmpty(TextBoxStartProject.Text) ||
            string.IsNullOrEmpty(textBoxProjectEnd.Text) ||
            string.IsNullOrEmpty(guna2TextBox1.Text) ||
            string.IsNullOrEmpty(guna2ComboBox1.Text))
            {
                MessageBox.Show("Please fill in all Task details!");
                return;
            }

            BStaskAdmin bStaskAdmin = new BStaskAdmin();
            string id_t = guna2TextBox2.Text;
            string id_p = textboxIDproject.Text;
            string name = TextBoxNameProject.Text;
            string desc = TextBoxDescProject.Text;
            DateTime dateTime = Convert.ToDateTime(TextBoxStartProject.Text);
            string Pri = textBoxProjectEnd.Text;
            string esti = guna2TextBox1.Text;
            string status = guna2ComboBox1.Text;

            //lấy ds
            List<Tasks> task = new List<Tasks>();
            task = bStaskAdmin.GetTasks();

            bool check = bStaskAdmin.checkIdTask(id_t, task);
            if (!check) 
            {
                bStaskAdmin.AddTask(id_t, name, desc, dateTime, status, Pri, esti, id_p);
                MessageBox.Show("Add task susecc");
                loadDataGrid();
                panel1_update.Visible = false;
            }
            else
            {
                MessageBox.Show("Add task not susecc");
            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAddUserTask_Click(object sender, EventArgs e)
        {
            BStaskAdmin bStaskAdmin = new BStaskAdmin();
            List<TaskAssignments> tasksA = new List<TaskAssignments>();
            tasksA = bStaskAdmin.GetTaskAssignments();
            string idEmp = ComboBoxIdEMP.Text;
            string idTask = ComboBoxIDTask.Text;
            if (!bStaskAdmin.checkIdTaskAssign(idTask, tasksA, idEmp))
            {
                bStaskAdmin.addTaskAssignment(idEmp, idTask);
                MessageBox.Show("add TaskAssignment succes");
            }
            else
            {
                MessageBox.Show("add TaskAssignment not succes");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TaskAssAdmin bTaskAssAdmin = new TaskAssAdmin();
            idTask = ComboBoxIDTask.Text;
            if (idTask != "")
            {
                bTaskAssAdmin.idTask = idTask;
                bTaskAssAdmin.Show();
            }
            else
            {
                MessageBox.Show("Chọn IdTask trước khi ấn vào nút này");
            }
        }

        private void Btn_delete_task_Click(object sender, EventArgs e)
        {
            BStaskAdmin bStaskAdmin = new BStaskAdmin();
            List<Tasks> tasksA = new List<Tasks>();
            tasksA = bStaskAdmin.GetTasks();
            string idTask = ComboBoxIDTask.Text;
            if (bStaskAdmin.checkIdTask(idTask, tasksA))
            {
                bStaskAdmin.DeleteTask( idTask);
                loadDataGrid();
                setComboBoxIDTask();
                MessageBox.Show("delete TaskAssignment succes");
            }
            else
            {
                MessageBox.Show("delete TaskAssignment not succes");
            }
        }
    }
}
