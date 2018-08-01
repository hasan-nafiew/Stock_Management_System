using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementProject.BLL;
using StockManagementProject.Models;

namespace StockManagementProject.Forms
{
    public partial class CompanySetupUI : Form
    {
        CompanyManager CompanyManager = new CompanyManager();
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
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Company company=new Company();

            company.Name = nameTextBox.Text;


        }
    }
}
