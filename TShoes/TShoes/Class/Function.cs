using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TShoes.Class
{
	class Function
	{
		public static SqlConnection connection;
		public static void Connect()
		{
			connection = new SqlConnection();
			connection.ConnectionString = "Data Source=DESKTOP-03II1QV;Initial Catalog=QuanLyGiayDep;Integrated Security=True";
			connection.Open();
		}
		public static void Disconnect()
		{
			if (connection.State == ConnectionState.Open)
			{
				connection.Close();
				connection.Dispose();
				connection = null;
			}
		}
	}
}
