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
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private Form activeFrom = null;
        public void openChildForm(Form formChildForm)
        {
            if (activeFrom != null)
            {
                activeFrom.Close();
            }
            activeFrom = formChildForm;
            formChildForm.TopLevel = false;
            formChildForm.FormBorderStyle = FormBorderStyle.None;
            formChildForm.Dock = DockStyle.Fill;
            guna2Panel2chill.Controls.Add(formChildForm);
            guna2Panel2chill.Tag = formChildForm;
            formChildForm.BringToFront();
            formChildForm.Show();
        }
        private void guna2Panel2chill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ls_menu_2_Click(object sender, EventArgs e)
        {
            ProjectAdmin proAdmin = new ProjectAdmin();
            proAdmin.Show();
        }

        private void ls_menu_3_Click(object sender, EventArgs e)
        {
            TaskAdmin taskAdmin = new TaskAdmin();
            taskAdmin.Show();
        }
    }
}
