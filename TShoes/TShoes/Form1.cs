using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TShoes
{
    public partial class frmlogin : DevExpress.XtraEditors.XtraForm
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        void Check()
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
