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
    public partial class Account : Form
    {
        private BSAccount bllAccount = new BSAccount();
        public Account()
        {
            InitializeComponent();
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            DGV_Account.DataSource = bllAccount.GetAllAccounts();
            DGV_Account.Columns["AccountId"].HeaderText = "Mã tài khoản";
            DGV_Account.Columns["UserName"].HeaderText = "Tên đăng nhập";
            DGV_Account.Columns["Password"].HeaderText = "Mật khẩu";
            DGV_Account.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            DGV_Account.Columns["Role"].HeaderText = "Vai trò";
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            Accounts newAccount = new Accounts
            {
                UserName = txtTentaikhoan.Text,
                PasswordHash = txtMatKhau.Text,
                Role = cbAccount.SelectedItem.ToString()
            };
            bllAccount.AddAccount(newAccount);
            LoadAccounts();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedAccountId = (int)DGV_Account.SelectedRows[0].Cells["AccountId"].Value;
            Accounts updatedAccount = new Accounts
            {
                AccountId = selectedAccountId,
                UserName = txtTentaikhoan.Text,
                PasswordHash = txtMatKhau.Text,
                Role = cbAccount.SelectedItem.ToString()
            };
            bllAccount.UpdateAccount(updatedAccount);
            LoadAccounts();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            char selectedAccountId = (char)DGV_Account.SelectedRows[0].Cells["AccountId"].Value;
            bllAccount.DeleteAccount(selectedAccountId);
            LoadAccounts();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text;
            DGV_Account.DataSource = bllAccount.SearchAccounts(keyword);
        }
    }
}
