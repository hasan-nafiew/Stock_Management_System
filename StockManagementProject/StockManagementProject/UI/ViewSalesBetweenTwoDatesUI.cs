﻿using System;
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
    public partial class ViewSalesBetweenTwoDatesUI : Form
    {
        public ViewSalesBetweenTwoDatesUI()
        {
            InitializeComponent();
        }

        private void ViewSalesBetweenTwoDatesUI_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
    }
}
