namespace StockManagementProject.Forms
{
    partial class StockInUI
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
            this.components = new System.ComponentModel.Container();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.reorderLabelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.reorderLevelLabel = new System.Windows.Forms.Label();
            this.availableQtyLabel = new System.Windows.Forms.Label();
            this.categoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVMBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // companyComboBox
            // 
            this.companyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.companyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.companyComboBox.DataSource = this.companyVMBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(165, 80);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(224, 21);
            this.companyComboBox.TabIndex = 23;
            this.companyComboBox.ValueMember = "Id";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.categoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryComboBox.DataSource = this.categoryVMBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(165, 38);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(224, 21);
            this.categoryComboBox.TabIndex = 24;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // reorderLabelTextBox
            // 
            this.reorderLabelTextBox.Location = new System.Drawing.Point(167, 226);
            this.reorderLabelTextBox.Name = "reorderLabelTextBox";
            this.reorderLabelTextBox.Size = new System.Drawing.Size(224, 20);
            this.reorderLabelTextBox.TabIndex = 22;
            this.reorderLabelTextBox.TextChanged += new System.EventHandler(this.reorderLabelTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Stock In Qty";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(167, 267);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(316, 267);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Item\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Reorder Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Available Qty";
            // 
            // itemComboBox
            // 
            this.itemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemComboBox.DataSource = this.itemVMBindingSource1;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(165, 122);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(224, 21);
            this.itemComboBox.TabIndex = 29;
            this.itemComboBox.ValueMember = "Id";
            // 
            // reorderLevelLabel
            // 
            this.reorderLevelLabel.AutoSize = true;
            this.reorderLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLevelLabel.Location = new System.Drawing.Point(229, 159);
            this.reorderLevelLabel.Name = "reorderLevelLabel";
            this.reorderLevelLabel.Size = new System.Drawing.Size(71, 16);
            this.reorderLevelLabel.TabIndex = 30;
            this.reorderLevelLabel.Text = "Category";
            // 
            // availableQtyLabel
            // 
            this.availableQtyLabel.AutoSize = true;
            this.availableQtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQtyLabel.Location = new System.Drawing.Point(229, 191);
            this.availableQtyLabel.Name = "availableQtyLabel";
            this.availableQtyLabel.Size = new System.Drawing.Size(71, 16);
            this.availableQtyLabel.TabIndex = 31;
            this.availableQtyLabel.Text = "Category";
            // 
            // categoryVMBindingSource
            // 
            this.categoryVMBindingSource.DataSource = typeof(StockManagementProject.Models.View.CategoryVM);
            // 
            // companyVMBindingSource
            // 
            this.companyVMBindingSource.DataSource = typeof(StockManagementProject.Models.View.CompanyVM);
            // 
            // itemVMBindingSource
            // 
            this.itemVMBindingSource.DataSource = typeof(StockManagementProject.Models.View.ItemVM);
            // 
            // itemVMBindingSource1
            // 
            this.itemVMBindingSource1.DataSource = typeof(StockManagementProject.Models.View.ItemVM);
            // 
            // StockInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 335);
            this.Controls.Add(this.availableQtyLabel);
            this.Controls.Add(this.reorderLevelLabel);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.reorderLabelTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockInUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock In ";
            this.Load += new System.EventHandler(this.StockInUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVMBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox reorderLabelTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label reorderLevelLabel;
        private System.Windows.Forms.Label availableQtyLabel;
        private System.Windows.Forms.BindingSource companyVMBindingSource;
        private System.Windows.Forms.BindingSource categoryVMBindingSource;
        private System.Windows.Forms.BindingSource itemVMBindingSource;
        private System.Windows.Forms.BindingSource itemVMBindingSource1;
    }
}