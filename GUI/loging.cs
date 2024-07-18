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
using Guna.UI2.WinForms;

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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtTaikhoan.Text;
                string password = txtMatKhau.Text;                                          
                BSLogin bslogin = new BSLogin();

                Users user = new Users
                {
                    UserName = username,
                    PasswordHash = password
                };
                string getUser = bslogin.CheckLogic(user);
                MessageBox.Show(getUser);
                if (getUser != null)
                {
                    string getRole = bslogin.CheckRole(getUser);
                    if (getRole.ToLower() == "admin") 
                    {
                        HomeAdmin acc = new HomeAdmin();
                        acc.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserProperties.UserId = getUser;
                        // Đăng nhập thành công, chuyển sang Form Home
                        Home homeForm = new Home();
                        homeForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    // Đăng nhập thất bại, hiển thị thông báo lỗi
                    MessageBox.Show("Đăng nhập không thành công!");
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo lỗi
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
                this.Show();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
