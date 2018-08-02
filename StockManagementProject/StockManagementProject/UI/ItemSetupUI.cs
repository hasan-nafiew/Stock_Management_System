using StockManagementProject.BLL;
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
    public partial class ItemSetupUI : Form
    {
        ItemManager _itemManger = new ItemManager();

        string _conString = ConString.DbConnection();
       
        public ItemSetupUI()
        {
            InitializeComponent();
        }

        private void ItemSetupUI_Load(object sender, EventArgs e)
        {
            SqlConnection _con = new SqlConnection(_conString);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            //categeoy combobox          
           
            string query = "select id,name from category";
            SqlCommand cmdc = new SqlCommand(query, _con);
            SqlDataAdapter da = new SqlDataAdapter(cmdc);
            _con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            categoryVMBindingSource.DataSource = dt;
            categoryComboBox.SelectedValue = -1;

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
            companyComboBox.SelectedText="      ----Select----";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = itemNameTextBox.Text;
            item.Reorderlevel = Convert.ToInt32(reorderLabelTextBox.Text);
            item.CategoryId = Convert.ToInt32(categoryComboBox.SelectedValue);
            item.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);

            bool isInserted = _itemManger.IsInsert(item);
            if (isInserted)
            {
                MessageBox.Show("Item inserted successfully");
                GetClear();
                return;

            }
            MessageBox.Show("Data Insert Failed");


        }
        public void GetClear()
        {
            itemNameTextBox.Text = String.Empty;
            companyComboBox.SelectedValue = -1;
            categoryComboBox.SelectedValue = -1;
            categoryComboBox.SelectedText = "    ----Select----";
            reorderLabelTextBox.Text = "";
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
