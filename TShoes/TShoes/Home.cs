using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TShoes
{
    public partial class frmHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void acelogout_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Close();
        }
    }
}
