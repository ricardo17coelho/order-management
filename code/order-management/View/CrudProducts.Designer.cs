namespace order_management
{
    partial class CrudProducts
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
            this.DataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.CBProductCategory = new System.Windows.Forms.ComboBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumPrice = new System.Windows.Forms.NumericUpDown();
            this.TxtUnit = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewProducts
            // 
            this.DataGridViewProducts.AllowUserToOrderColumns = true;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProducts.Location = new System.Drawing.Point(481, 119);
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.RowHeadersWidth = 102;
            this.DataGridViewProducts.Size = new System.Drawing.Size(794, 260);
            this.DataGridViewProducts.TabIndex = 0;
            this.DataGridViewProducts.Text = "dataGridView1";
            // 
            // CBProductCategory
            // 
            this.CBProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProductCategory.FormattingEnabled = true;
            this.CBProductCategory.Location = new System.Drawing.Point(26, 595);
            this.CBProductCategory.Name = "CBProductCategory";
            this.CBProductCategory.Size = new System.Drawing.Size(407, 49);
            this.CBProductCategory.TabIndex = 1;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(26, 129);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(416, 47);
            this.TxtProductName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // NumPrice
            // 
            this.NumPrice.Location = new System.Drawing.Point(26, 282);
            this.NumPrice.Name = "NumPrice";
            this.NumPrice.Size = new System.Drawing.Size(416, 47);
            this.NumPrice.TabIndex = 4;
            // 
            // TxtUnit
            // 
            this.TxtUnit.Location = new System.Drawing.Point(26, 437);
            this.TxtUnit.Name = "TxtUnit";
            this.TxtUnit.Size = new System.Drawing.Size(416, 47);
            this.TxtUnit.TabIndex = 2;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(26, 381);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(73, 41);
            this.labelUnit.TabIndex = 3;
            this.labelUnit.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProductCategory";
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.Location = new System.Drawing.Point(26, 737);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Size = new System.Drawing.Size(285, 63);
            this.CmdAddNew.TabIndex = 5;
            this.CmdAddNew.Text = "Add New";
            this.CmdAddNew.UseVisualStyleBackColor = true;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // CrudProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3776, 1536);
            this.Controls.Add(this.CmdAddNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.TxtUnit);
            this.Controls.Add(this.NumPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.CBProductCategory);
            this.Controls.Add(this.DataGridViewProducts);
            this.Name = "CrudProducts";
            this.Text = "CrudProducts";
            this.Load += new System.EventHandler(this.CrudProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewProducts;
        private System.Windows.Forms.ComboBox CBProductCategory;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumPrice;
        private System.Windows.Forms.TextBox TxtUnit;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdAddNew;
    }
}