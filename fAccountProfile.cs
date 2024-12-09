using Qlyquancafe.DAO;
using Qlyquancafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlyquancafe
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txbUserName.Text = LoginAccount.UserName;
            txbDisplay.Text = LoginAccount.DisplayName;

            
        }

        void UpdateAccountInfo()
        {
            string displayName = txbDisplay.Text;
            string passWord = txbPassword.Text;
            string newpass = txbNewPassword.Text;
            string reenterPass = txbReenterpass.Text;
            string userName = txbUserName.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới !");
            }
            else
            {
                if(AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, newpass))
                {
                    MessageBox.Show("Cập nhật thành công !");
                    if(updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu !");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove {  updateAccount -= value; }
        

        }
        private void btnExti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }
            public AccountEvent(Account acc)
            {
                this.acc = acc;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
