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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            customizeDes();
        }
        private void customizeDes()
        {
            panelProjectDropDown.Visible = false;
            PanelDropDownTask.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelProjectDropDown.Visible == true)
            {
                panelProjectDropDown.Visible = false;
            }
            if (PanelDropDownTask.Visible == true)
            {
                PanelDropDownTask.Visible = false;
            }
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false) 
            {
                hideSubMenu();
                submenu.Visible = true;
            }else { submenu .Visible = false; }
        }
        private void btn_task_show_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelDropDownTask);
        }
        private void bnt_show_Project_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProjectDropDown);
        }

        private Form activeFrom = null;
        private void openChildForm(Form formChildForm)
        {
            if (activeFrom != null)
            {
                activeFrom.Close();
            }
            activeFrom = formChildForm;
            formChildForm.TopLevel = false;
            formChildForm.FormBorderStyle = FormBorderStyle.None;
            formChildForm.Dock = DockStyle.Fill;
            childerform.Controls.Add(formChildForm);
            childerform.Tag = formChildForm;
            formChildForm.BringToFront();
            formChildForm.Show();
        }


        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_home_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new loging());
        }
    }
}
