using DOT;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class loging : Form
    {
        Users username = new Users();
        BSLogin bslogin = new BSLogin();

        public loging()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_input(object sender, EventArgs e)
        {
            txtTaikhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtTaikhoan.Text;
                string password = txtMatKhau.Text;
                BSLogin bslogin = new BSLogin();

                Users user = BSLogin.Login(username, password);
                string getUser = bslogin.CheckLogic(user);

                if (getUser != null)
                {
                    // Đăng nhập thành công, chuyển sang Form Home
                    Home homeForm = new Home();
                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    // Đăng nhập thất bại, hiển thị thông báo lỗi
                    MessageBox.Show("Đăng nhập không thành công!");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo lỗi
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
        }
    }
}
