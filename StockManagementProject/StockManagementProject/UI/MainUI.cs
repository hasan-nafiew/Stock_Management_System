using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementProject.Forms
{
    public partial class MainUI : Form
    {
        CategorySetupUI _categorySetupUi = new CategorySetupUI();
        CompanySetupUI _companySetupUi=new CompanySetupUI();
        ItemSetupUI _itemSetupUi=new ItemSetupUI();
        StockInUI _stockInUi=new StockInUI();
        StockOutUI _stockOutUi=new StockOutUI();
        SearchAndViewItemSummaryUI _searchAndViewItemSummaryUi=new SearchAndViewItemSummaryUI();
        ViewSalesBetweenTwoDatesUI _viewSalesBetweenTwoDatesUi=new ViewSalesBetweenTwoDatesUI();


        public MainUI()
        {
            InitializeComponent();
        }

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_categorySetupUi.IsDisposed)
            {
                _categorySetupUi=new CategorySetupUI();
            }
            _categorySetupUi.MdiParent = this;
            _categorySetupUi.Show();
            _categorySetupUi.BringToFront();


        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_companySetupUi.IsDisposed)
            {
                _companySetupUi=new CompanySetupUI();
            }
            _companySetupUi.MdiParent = this;
            _companySetupUi.Show();
            _companySetupUi.BringToFront();
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_itemSetupUi.IsDisposed)
            {
                _itemSetupUi=new ItemSetupUI();
            }
            _itemSetupUi.MdiParent = this;
            _itemSetupUi.Show();
            _itemSetupUi.BringToFront();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_stockInUi.IsDisposed)
            {
                _stockInUi=new StockInUI();
            }
            _stockInUi.MdiParent = this;
            _stockInUi.Show();
            _stockInUi.BringToFront();

        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_stockOutUi.IsDisposed)
            {
                _stockOutUi=new StockOutUI();
            }
            _stockOutUi.MdiParent = this;
            _stockOutUi.Show();
            _stockOutUi.BringToFront();
        }

        private void searchAndViewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_searchAndViewItemSummaryUi.IsDisposed)
                _searchAndViewItemSummaryUi=new SearchAndViewItemSummaryUI();
            _searchAndViewItemSummaryUi.MdiParent = this;
            _searchAndViewItemSummaryUi.Show();
            _searchAndViewItemSummaryUi.BringToFront();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_viewSalesBetweenTwoDatesUi.IsDisposed)
            {
                _viewSalesBetweenTwoDatesUi=new ViewSalesBetweenTwoDatesUI();
            }
            _viewSalesBetweenTwoDatesUi.MdiParent = this;
               _viewSalesBetweenTwoDatesUi.Show();
            _viewSalesBetweenTwoDatesUi.BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripStokIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(baseLib.mycls.callme());
        }
    }
}
