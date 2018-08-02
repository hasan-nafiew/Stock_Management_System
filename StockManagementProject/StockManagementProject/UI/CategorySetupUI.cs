using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StockManagementProject.BLL;
using StockManagementProject.Models;

namespace StockManagementProject.Forms
{
    public partial class CategorySetupUI : Form
    {
        CategoryManager _categoryManager=new CategoryManager();
        public CategorySetupUI()
        {
            InitializeComponent();
        }

        private void CategorySetupUI_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            //Grid view
            string _conString = ConString.DbConnection();
            SqlConnection con = new SqlConnection(_conString);
            string query = "select id,name from category order by id desc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            categoryVMBindingSource.DataSource = dt;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           Category category=new Category();

            category.Name = nameTextBox.Text;

            bool isInserted = _categoryManager.IsInserted(category);
            if (isInserted)
            {
                MessageBox.Show("Data Inserted ");
                nameTextBox.Text=String.Empty;
                nameTextBox.Focus();
                return;
            }
            MessageBox.Show("Data Failed");

        }
    }
}
