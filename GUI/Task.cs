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
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GUI
{
    public partial class Task : Form
    {
        string userID = UserProperties.UserId;
        string ProjectID = ProjectPropertise.ProjectId;
        private string idTaskClick;
        private string[] myArray = { "Cần làm", "Chưa bắt đầu", "Hoàn thiện", "Đang tiến hành" };
        public Task()
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
        private void Task_Load(object sender, EventArgs e)
        {
            setComboBox();
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
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                if (cell is DataGridViewButtonCell buttonCell)
                {
                    guna2PanelDetail.Visible = true;

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
                    idTaskClick = data1;
                    // Update TextBox with the data
                    htmlNameTask.Text = data2;
                    htmlDesc.Text = data3;
                    htmlDueDate.Text = data4;
                    htmlPri.Text = data6;
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        if (myArray[i] == data5)
                        {
                            guna2ComboBox1.SelectedIndex = i;
                        }
                    }
                }
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            BSHOME sHOME = new BSHOME();
            List<Tasks> task = new List<Tasks>();
            task = sHOME.GetTask(ProjectID);
            dataGridView1.DataSource = task;
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Task_MouseClick(object sender, MouseEventArgs e)
        {
            guna2PanelDetail.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            BSHOME sHOME = new BSHOME();
            try
            {
                string value = guna2ComboBox1.Text;
                sHOME.updateTaskStatus(idTaskClick, value);
                MessageBox.Show("update sucess");
                guna2PanelDetail.Visible = false;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
