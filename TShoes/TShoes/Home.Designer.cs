
namespace TShoes
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.acehome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acesanpham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acedonhang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acetaodonhangmoi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acecapnhatdonhang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acexemdonhang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceaccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acexemtaikhoan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acelogout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acehome,
            this.acesanpham,
            this.acedonhang,
            this.aceaccount});
            this.accordionControl1.Location = new System.Drawing.Point(0, 27);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.NormalWidth = 260;
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(40, 503);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // acehome
            // 
            this.acehome.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.acehome.Name = "acehome";
            this.acehome.Text = "Trang Chủ";
            this.acehome.Click += new System.EventHandler(this.acehome_Click);
            // 
            // acesanpham
            // 
            this.acesanpham.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.acesanpham.Name = "acesanpham";
            this.acesanpham.Text = "Sản Phẩm";
            this.acesanpham.Click += new System.EventHandler(this.acesanpham_Click);
            // 
            // acedonhang
            // 
            this.acedonhang.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acetaodonhangmoi,
            this.acecapnhatdonhang,
            this.acexemdonhang});
            this.acedonhang.Expanded = true;
            this.acedonhang.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.acedonhang.Name = "acedonhang";
            this.acedonhang.Text = "Đơn hàng";
            // 
            // acetaodonhangmoi
            // 
            this.acetaodonhangmoi.Name = "acetaodonhangmoi";
            this.acetaodonhangmoi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acetaodonhangmoi.Text = "Tạo Đơn Hàng mới ";
            this.acetaodonhangmoi.Click += new System.EventHandler(this.acetaodonhangmoi_Click);
            // 
            // acecapnhatdonhang
            // 
            this.acecapnhatdonhang.Name = "acecapnhatdonhang";
            this.acecapnhatdonhang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acecapnhatdonhang.Text = "Cập nhật đơn hàng";
            this.acecapnhatdonhang.Click += new System.EventHandler(this.acecapnhatdonhang_Click);
            // 
            // acexemdonhang
            // 
            this.acexemdonhang.Name = "acexemdonhang";
            this.acexemdonhang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acexemdonhang.Text = "Xem danh sách đơn hàng";
            this.acexemdonhang.Click += new System.EventHandler(this.acexemdonhang_Click);
            // 
            // aceaccount
            // 
            this.aceaccount.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acexemtaikhoan,
            this.acelogout});
            this.aceaccount.Expanded = true;
            this.aceaccount.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.aceaccount.Name = "aceaccount";
            this.aceaccount.Text = "Tài Khoản";
            // 
            // acexemtaikhoan
            // 
            this.acexemtaikhoan.Name = "acexemtaikhoan";
            this.acexemtaikhoan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acexemtaikhoan.Text = "Xem tài khoản";
            this.acexemtaikhoan.Click += new System.EventHandler(this.acexemtaikhoan_Click);
            // 
            // acelogout
            // 
            this.acelogout.Name = "acelogout";
            this.acelogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acelogout.Text = "Đăng Xuất";
            this.acelogout.Click += new System.EventHandler(this.acelogout_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(810, 27);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(40, 27);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(770, 503);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 530);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmHome";
            this.NavigationControl = this.accordionControl1;
            this.Text = "TSHOES";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acehome;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acesanpham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acedonhang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceaccount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acexemtaikhoan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acelogout;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acetaodonhangmoi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acecapnhatdonhang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acexemdonhang;
    }
}