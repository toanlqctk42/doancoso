using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TShoes.UI.Modules
{
    public partial class uchome : DevExpress.XtraEditors.XtraUserControl
    {
        public uchome()
        {
            InitializeComponent();
        }

        private void btnThaydoi_Click(object sender, EventArgs e)
        {
            txtGioithieu.ReadOnly = false;
            mtbNgaythanhlap.ReadOnly = false;
            txtBoss.ReadOnly = false;
            txtsdtshop.ReadOnly = false;
            txtDiachishop.ReadOnly = false;
            mtbGiomocua.ReadOnly = false;
            mtpGiodongcua.ReadOnly = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThaydoi.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.txtGioithieu.Text = txtGioithieu.Text;
            this.mtbNgaythanhlap.Text = mtbNgaythanhlap.Text;
            btnHuy.PerformClick();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtGioithieu.ReadOnly = true;
            mtbNgaythanhlap.ReadOnly = true;
            txtBoss.ReadOnly = true;
            txtsdtshop.ReadOnly = true;
            txtDiachishop.ReadOnly = true;
            mtbGiomocua.ReadOnly = true;
            mtpGiodongcua.ReadOnly = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThaydoi.Enabled = true;
        }
    }
}
