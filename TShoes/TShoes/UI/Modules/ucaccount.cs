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
    public partial class ucaccount : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        public ucaccount()
        {
            InitializeComponent();
        }

        private void btnThemAccount_Click(object sender, EventArgs e)
        {

        }
        void Unlock()
        {
            txtTendangnhap.ReadOnly = false;
            txtmatkhau.ReadOnly = false;
            txtxacnhanmatkhau.ReadOnly = false;
            dtpngaykichhoat.Enabled = true;
            cbochucvu.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThemAccount.Enabled = false;
            btnCapnhat.Enabled = false;
            paneltimkiem.Enabled = false;
        }
        void Lock()
        {
            txtTendangnhap.ReadOnly = true;
            txtmatkhau.ReadOnly = true;
            txtxacnhanmatkhau.ReadOnly = true;
            dtpngaykichhoat.Enabled = false;
            cbochucvu.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThemAccount.Enabled = true;
            btnCapnhat.Enabled = true;
            paneltimkiem.Enabled = true;
        }

    }
}
