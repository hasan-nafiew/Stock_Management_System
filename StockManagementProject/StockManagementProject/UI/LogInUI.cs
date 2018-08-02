using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementProject.Models;

namespace StockManagementProject.UI
{
    public partial class LogInUI : Form
    {
        public LogInUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string conString = ConString.DbConnection();
            SqlConnection con=new SqlConnection(conString);
            string query = "select id,name,password from login";
            SqlCommand command=new SqlCommand(query,con);

            SqlDataAdapter da=new SqlDataAdapter(command);
            DataTable dt=new DataTable();
        }
    }
}
