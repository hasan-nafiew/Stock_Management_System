﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementProject.BLL;
using StockManagementProject.DAL;
using StockManagementProject.Models;

namespace StockManagementProject.Forms
{
    public partial class CompanySetupUI : Form
    {
        CompanyManager _companyManager = new CompanyManager();
        SqlConnection _con = Connection.ConnectionSetup;
        public CompanySetupUI()
            
        {
            InitializeComponent();
        }

        private void CompanySetupUI_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //Grid view                  
            string query = "select id,name from company order by id desc";
            SqlCommand cmd = new SqlCommand(query, _con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            companyVMBindingSource.DataSource = dt;



        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Company company=new Company();

            company.Name = nameTextBox.Text;
            try
            {

                bool isInserted = _companyManager.IsInserted(company);
                if (isInserted)
                {
                    MessageBox.Show("Data Inserted");
                    nameTextBox.Text = String.Empty;
                    nameTextBox.Focus();                  
                   
                  
                    return;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nameTextBox.Focus();
            }


        }
        public void ReloadForm()
        {
            companyDataGridView.Update();
            nameTextBox.ResetText();
        }
    }
}
