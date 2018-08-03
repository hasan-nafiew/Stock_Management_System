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
        private int rowIndex = 0;
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
                if (nameTextBox.Text == String.Empty)
                {
                    MessageBox.Show("please enter the category");
                }
                else
                {
                    Category category = new Category();
                    category.Name = nameTextBox.Text;
                    //unique check
                    bool flag = false;
                    string conString1 = ConString.DbConnection();
                    SqlConnection connection = new SqlConnection(conString1);
                    string query2 = "select id,name from  category";
                    SqlCommand command = new SqlCommand(query2, connection);
                    connection.Open();
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[1].ToString() == category.Name)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        lblNameValidation.Text = "This Category Exists";
                        lblNameValidation.ForeColor = Color.Red;
                        return;
                    }
                    bool isInserted = _categoryManager.IsInserted(category);
                    if (isInserted)
                    {
                        MessageBox.Show("Data Inserted ");
                        nameTextBox.Text = String.Empty;
                        lblNameValidation.Text = String.Empty;
                        nameTextBox.Focus();
                        //
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

                        return;
                    }
                    MessageBox.Show("Data Failed");
                }
            }
            

     

        

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            Category category=new Category();
           
            

          


            //end unique check
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != null)
            {
                lblNameValidation.Text = "";
            }
        }

        private void categoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            rowIndex = e.RowIndex;
            DataGridViewRow row = categoryDataGridView.Rows[rowIndex];
            nameTextBox.Text = row.Cells[1].Value.ToString();
            saveButton.Text = "Update";
        }
    }
}
