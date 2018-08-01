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
    public partial class SearchAndViewItemSummaryUI : Form
    {
        public SearchAndViewItemSummaryUI()
        {
            InitializeComponent();
        }
      
        private void SearchAndViewItemSummaryUI_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
    }
}
