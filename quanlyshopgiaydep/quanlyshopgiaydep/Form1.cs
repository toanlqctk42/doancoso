using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyshopgiaydep
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            
            InitializeComponent();
        }
        public bool isEmpty()
        {
            if (txtAccountName.Text.Length <= 0 || txtPassword.Text.Length <= 0)
                return true;
            return false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Vui lòng không để trống user và password", "Thông báo");
            }
            else if (txtAccountName.Text == "toan" && txtPassword.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công", "chúc mừng");
            }
            else
            {
                MessageBox.Show("User hoặc password của bạn đã sai , vui lòng nhập lại", "xin chia buồn");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
