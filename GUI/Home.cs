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
    public partial class Home : Form
    {
        // lấy userID từ UserProperties
        string userID = UserProperties.UserId;
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            BSHOME sHOME = new BSHOME();
            Employyees employyee = sHOME.GetEml(userID);

            guna2ShadowForm1.SetShadowForm(this);
            customizeDes();
            nameUser.Text = employyee.EmployeeEmail;
        }

        // hàm set panelDropDown Visible mặc định là false
        private void customizeDes()
        {
            panelProjectDropDown.Visible = false;
            PanelDropDownTask.Visible = false;
        }
        //Hàm logic Dóng Menu
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
        //Hàm mở menu
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
            childerform.Controls.Add(formChildForm);
            childerform.Tag = formChildForm;
            formChildForm.BringToFront();
            formChildForm.Show();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new  ProjectAll());
            hideSubMenu();
        }
        private void ls_menu_1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Task());
            hideSubMenu();
        }
    }
}
