using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TShoes.Class;


namespace TShoes
{
    public partial class frmlogin : DevExpress.XtraEditors.XtraForm 
    {
        
        //SqlConnection connection;
        //string server = "Data Source=DESKTOP-03II1QV;Initial Catalog=QuanLyGiayDep;Integrated Security=True";
        //SqlCommand command;
        public frmlogin()
        {
            InitializeComponent();
        }
        private void frmlogin_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
            SqlHelper.connection = new SqlConnection(SqlHelper.ConnectString);
            SqlHelper.connection.Open();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
			SqlCommand command;

			//connection = new SqlConnection(server);
			command = new SqlCommand("select * from AccountName where AccountName = @tk and Password = @mk ", SqlHelper.connection);
			SqlParameter tk = new SqlParameter();
			tk.ParameterName = "@tk";
			tk.Value = txtUser.Text;
			command.Parameters.Add(tk);
			SqlParameter mk = new SqlParameter();
			mk.ParameterName = "@mk";
			mk.Value = txtPassword.Text;
			command.Parameters.Add(mk);
			try
			{
				//connection.Open();
				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					frmHome home = new frmHome();
					home.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Lỗi đăng nhập vui lòng thử lại ", "Thông báo");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void btnoff_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
	}
}
