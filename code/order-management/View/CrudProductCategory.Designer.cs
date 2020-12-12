namespace order_management.View
{
    partial class CrudProductCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudProductCategory));
            this.DataGridViewProductCategories = new System.Windows.Forms.DataGridView();
            this.TxtProductCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdAddNew = new System.Windows.Forms.Button();
            this.CBParentCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitleSettings = new System.Windows.Forms.Label();
            this.pictureBoxPnlProducts = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.treeViewCategories = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductCategories)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewProductCategories
            // 
            this.DataGridViewProductCategories.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.DataGridViewProductCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProductCategories.Location = new System.Drawing.Point(828, 2);
            this.DataGridViewProductCategories.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewProductCategories.Name = "DataGridViewProductCategories";
            this.DataGridViewProductCategories.RowHeadersWidth = 102;
            this.DataGridViewProductCategories.Size = new System.Drawing.Size(822, 391);
            this.DataGridViewProductCategories.TabIndex = 0;
            this.DataGridViewProductCategories.Text = "dataGridView1";
            // 
            // TxtProductCategoryName
            // 
            this.TxtProductCategoryName.Location = new System.Drawing.Point(412, 2);
            this.TxtProductCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProductCategoryName.Name = "TxtProductCategoryName";
            this.TxtProductCategoryName.Size = new System.Drawing.Size(249, 39);
            this.TxtProductCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Category Name";
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.Location = new System.Drawing.Point(11, 524);
            this.CmdAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Size = new System.Drawing.Size(191, 43);
            this.CmdAddNew.TabIndex = 3;
            this.CmdAddNew.Text = "Add New";
            this.CmdAddNew.UseVisualStyleBackColor = true;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // CBParentCategory
            // 
            this.CBParentCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBParentCategory.FormattingEnabled = true;
            this.CBParentCategory.Location = new System.Drawing.Point(412, 102);
            this.CBParentCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CBParentCategory.Name = "CBParentCategory";
            this.CBParentCategory.Size = new System.Drawing.Size(269, 40);
            this.CBParentCategory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parent Category";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DataGridViewProductCategories, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1652, 395);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CBParentCategory, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtProductCategoryName, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(820, 200);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblTitleSettings
            // 
            this.lblTitleSettings.AutoEllipsis = true;
            this.lblTitleSettings.AutoSize = true;
            this.lblTitleSettings.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleSettings.ForeColor = System.Drawing.Color.White;
            this.lblTitleSettings.Location = new System.Drawing.Point(140, -2);
            this.lblTitleSettings.Name = "lblTitleSettings";
            this.lblTitleSettings.Size = new System.Drawing.Size(406, 93);
            this.lblTitleSettings.TabIndex = 3;
            this.lblTitleSettings.Text = "Categories";
            // 
            // pictureBoxPnlProducts
            // 
            this.pictureBoxPnlProducts.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPnlProducts.Image")));
            this.pictureBoxPnlProducts.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPnlProducts.Name = "pictureBoxPnlProducts";
            this.pictureBoxPnlProducts.Size = new System.Drawing.Size(117, 96);
            this.pictureBoxPnlProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPnlProducts.TabIndex = 4;
            this.pictureBoxPnlProducts.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblTitleSettings);
            this.pnlTop.Controls.Add(this.pictureBoxPnlProducts);
            this.pnlTop.Location = new System.Drawing.Point(12, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1637, 106);
            this.pnlTop.TabIndex = 11;
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.Location = new System.Drawing.Point(74, 624);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new System.Drawing.Size(644, 361);
            this.treeViewCategories.TabIndex = 12;
            // 
            // CrudProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1654, 1050);
            this.Controls.Add(this.treeViewCategories);
            this.Controls.Add(this.CmdAddNew);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrudProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrudProductCategory";
            this.Load += new System.EventHandler(this.CrudProductCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductCategories)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewProductCategories;
        private System.Windows.Forms.TextBox TxtProductCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdAddNew;
        private System.Windows.Forms.ComboBox CBParentCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTitleSettings;
        private System.Windows.Forms.PictureBox pictureBoxPnlProducts;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TreeView treeViewCategories;
    }
}