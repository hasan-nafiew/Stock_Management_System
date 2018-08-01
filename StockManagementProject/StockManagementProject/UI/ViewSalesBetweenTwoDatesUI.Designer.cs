namespace StockManagementProject.Forms
{
    partial class ViewSalesBetweenTwoDatesUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.fromDateComboBox = new System.Windows.Forms.ComboBox();
            this.toDateComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGridView
            // 
            this.searchGridView.AllowUserToAddRows = false;
            this.searchGridView.AllowUserToDeleteRows = false;
            this.searchGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colItem,
            this.colAvailableQty});
            this.searchGridView.Location = new System.Drawing.Point(17, 169);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.ReadOnly = true;
            this.searchGridView.Size = new System.Drawing.Size(703, 165);
            this.searchGridView.TabIndex = 55;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(413, 114);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 23);
            this.searchButton.TabIndex = 54;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // fromDateComboBox
            // 
            this.fromDateComboBox.FormattingEnabled = true;
            this.fromDateComboBox.Location = new System.Drawing.Point(262, 27);
            this.fromDateComboBox.Name = "fromDateComboBox";
            this.fromDateComboBox.Size = new System.Drawing.Size(224, 21);
            this.fromDateComboBox.TabIndex = 52;
            // 
            // toDateComboBox
            // 
            this.toDateComboBox.FormattingEnabled = true;
            this.toDateComboBox.Location = new System.Drawing.Point(262, 66);
            this.toDateComboBox.Name = "toDateComboBox";
            this.toDateComboBox.Size = new System.Drawing.Size(224, 21);
            this.toDateComboBox.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "To Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "From Date";
            // 
            // colId
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colId.FillWeight = 30.45685F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colItem
            // 
            this.colItem.FillWeight = 214.3157F;
            this.colItem.HeaderText = "Items";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colAvailableQty
            // 
            this.colAvailableQty.FillWeight = 55.22749F;
            this.colAvailableQty.HeaderText = "Sales Qty";
            this.colAvailableQty.Name = "colAvailableQty";
            this.colAvailableQty.ReadOnly = true;
            // 
            // ViewSalesBetweenTwoDatesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 361);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fromDateComboBox);
            this.Controls.Add(this.toDateComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ViewSalesBetweenTwoDatesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Sales Between Two Dates";
            this.Load += new System.EventHandler(this.ViewSalesBetweenTwoDatesUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox fromDateComboBox;
        private System.Windows.Forms.ComboBox toDateComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailableQty;
    }
}