using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TShoes.UI.Modules;

namespace TShoes
{
    public partial class frmHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmHome()
        {
            
            InitializeComponent();
            int widthscreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heighscreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthscreen;
            this.Height = heighscreen;
            float WidthPerscpective = (float)Width / 820;
            float HeightPerscpective = (float)Height / 535;
            ResizeAllControls(this, WidthPerscpective, HeightPerscpective);
            this.fluentDesignFormContainer1.Controls.Add(new ucsanpham() { Dock = DockStyle.Fill });
        }

        private void ResizeAllControls(Control recussiveControl, float widthPerscpective, float heightPerscpective)
        {
            foreach (Control control in recussiveControl.Controls)
            {
                if (control.Controls.Count != 0)

                    ResizeAllControls(control, widthPerscpective, heightPerscpective);

                //canh lại toạ độ x, y, chiều rộng, cao cho các control trên form

                control.Left = (int)(control.Left * widthPerscpective);

                control.Top = (int)(control.Top * heightPerscpective);

                control.Width = (int)(control.Width * widthPerscpective);

                control.Height = (int)(control.Height * heightPerscpective);

            }
        }

        private void acelogout_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Close();
        }
        public async Task LoadModuleAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
            {
                if(!fluentDesignFormContainer1.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate () 
                        {
                            fluentDesignFormContainer1.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                    var control = fluentDesignFormContainer1.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                        fluentDesignFormContainer1.Invoke(new MethodInvoker(delegate ()
                        {
                            control[0].BringToFront();
                        }));
                }
            }
            );
        }
        

        private async void acehome_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucsanpham") == null)
                ModulesInfo.Add(new ModuleInfo("ucsanpham", "TShoes.UI.Modules.ucsanpham"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucsanpham"));
        }


        private async void acexemtaikhoan_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucaccount") == null)
                ModulesInfo.Add(new ModuleInfo("ucaccount", "TShoes.UI.Modules.ucaccount"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucaccount"));
        }

        private async void acetaodonhangmoi_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucBills") == null)
                ModulesInfo.Add(new ModuleInfo("ucBills", "TShoes.UI.Modules.ucBills"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucBills"));
        }

        private async void acecapnhatdonhang_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucBills") == null)
                ModulesInfo.Add(new ModuleInfo("ucBills", "TShoes.UI.Modules.ucBills"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucBills"));
        }

        private async void acexemdonhang_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("ucdonhang") == null)
                ModulesInfo.Add(new ModuleInfo("ucdonhang", "TShoes.UI.Modules.ucdonhang"));
            await LoadModuleAsync(ModulesInfo.GetItem("ucdonhang"));
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
        }
    }
}
