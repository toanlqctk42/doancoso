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
	class SqlHelper
	{
		
		public static string ConnectString = "Data Source=DESKTOP-03II1QV;Initial Catalog = QuanLyGiayDep; Integrated Security = True";
		public static SqlConnection connection;
	}
}
