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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudProducts));
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBoxPnlProducts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewProducts
            // 
            this.DataGridViewProducts.AllowUserToOrderColumns = true;
            this.DataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewProducts.BackgroundColor = System.Drawing.Color.Gray;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProducts.Location = new System.Drawing.Point(853, 2);
            this.DataGridViewProducts.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.RowHeadersWidth = 102;
            this.DataGridViewProducts.Size = new System.Drawing.Size(847, 694);
            this.DataGridViewProducts.TabIndex = 0;
            this.DataGridViewProducts.Text = "dataGridView1";
            // 
            // CBProductCategory
            // 
            this.CBProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProductCategory.FormattingEnabled = true;
            this.CBProductCategory.Location = new System.Drawing.Point(424, 298);
            this.CBProductCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CBProductCategory.Name = "CBProductCategory";
            this.CBProductCategory.Size = new System.Drawing.Size(419, 40);
            this.CBProductCategory.TabIndex = 1;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProductName.Location = new System.Drawing.Point(424, 2);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(419, 39);
            this.TxtProductName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // NumPrice
            // 
            this.NumPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumPrice.Location = new System.Drawing.Point(424, 105);
            this.NumPrice.Margin = new System.Windows.Forms.Padding(2);
            this.NumPrice.Name = "NumPrice";
            this.NumPrice.Size = new System.Drawing.Size(419, 39);
            this.NumPrice.TabIndex = 4;
            // 
            // TxtUnit
            // 
            this.TxtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnit.Location = new System.Drawing.Point(424, 208);
            this.TxtUnit.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnit.Name = "TxtUnit";
            this.TxtUnit.Size = new System.Drawing.Size(419, 39);
            this.TxtUnit.TabIndex = 2;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnit.ForeColor = System.Drawing.Color.White;
            this.labelUnit.Location = new System.Drawing.Point(2, 206);
            this.labelUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(79, 45);
            this.labelUnit.TabIndex = 3;
            this.labelUnit.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProductCategory";
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.Location = new System.Drawing.Point(2, 398);
            this.CmdAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Size = new System.Drawing.Size(418, 72);
            this.CmdAddNew.TabIndex = 5;
            this.CmdAddNew.Text = "Add New";
            this.CmdAddNew.UseVisualStyleBackColor = true;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridViewProducts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 142);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1702, 698);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CmdAddNew, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtUnit, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CBProductCategory, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.NumPrice, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelUnit, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TxtProductName, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(845, 472);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pictureBoxPnlProducts);
            this.pnlTop.Location = new System.Drawing.Point(6, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1716, 112);
            this.pnlTop.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(129, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 93);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Products";
            // 
            // pictureBoxPnlProducts
            // 
            this.pictureBoxPnlProducts.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPnlProducts.Image")));
            this.pictureBoxPnlProducts.Location = new System.Drawing.Point(6, -2);
            this.pictureBoxPnlProducts.Name = "pictureBoxPnlProducts";
            this.pictureBoxPnlProducts.Size = new System.Drawing.Size(128, 114);
            this.pictureBoxPnlProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPnlProducts.TabIndex = 4;
            this.pictureBoxPnlProducts.TabStop = false;
            // 
            // CrudProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1734, 1203);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrudProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrudProducts";
            this.Load += new System.EventHandler(this.CrudProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBoxPnlProducts;
    }
}