using StockManagementProject.Models;
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

namespace StockManagementProject.Forms
{
    public partial class StockInUI : Form
    {
        string _conString = ConString.DbConnection();
        public StockInUI()
        {
            InitializeComponent();
        }

        private void reorderLabelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void StockInUI_Load(object sender, EventArgs e)
        {
            SqlConnection _con = new SqlConnection(_conString);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            //category combobox load
            string query = "select id,name from category";
            SqlCommand cmdc = new SqlCommand(query, _con);
            SqlDataAdapter da = new SqlDataAdapter(cmdc);
            _con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            categoryVMBindingSource.DataSource = dt;
            categoryComboBox.SelectedValue = -1;
            categoryComboBox.SelectedText = "         ----Select----";
            

            //company combobox           

            string query2 = "select id,name from company";
            SqlCommand cmd = new SqlCommand(query2, _con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            _con.Open();
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            _con.Close();
            companyVMBindingSource.DataSource = dt2;
            companyComboBox.SelectedValue = -1;
            companyComboBox.SelectedText = "         ----Select----";
            
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(_conString);
                string query = "select id,name from item where categoryId=@categoryId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@categoryId", categoryComboBox.SelectedValue);

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                itemVMBindingSource1.DataSource = dt;
                //itemComboBox.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
