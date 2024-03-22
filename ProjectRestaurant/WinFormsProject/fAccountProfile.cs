using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsProject.DAO;
using WinFormsProject.DTO;

namespace WinFormsProject
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(LoginAccount); }
        }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtUsername.Text = LoginAccount.UserName;
            txtDisplayName.Text = LoginAccount.DisplayName;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        void UpdateAccountInfo()
        {
            string displayName = txtDisplayName.Text;
            string password = txtPassword.Text;
            string newpass = txtNewPass.Text;
            string reenterPass = txtReEnterPass.Text;
            string userName = txtUsername.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }

    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc { get; set; }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
