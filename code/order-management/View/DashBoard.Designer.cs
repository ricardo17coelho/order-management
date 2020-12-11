namespace order_management
{
    partial class DashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.pictureBoxPnlCustomer = new System.Windows.Forms.PictureBox();
            this.lblCustomersCount = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.pictureBoxPnlProducts = new System.Windows.Forms.PictureBox();
            this.lblProductsCount = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPnlOrders = new System.Windows.Forms.PictureBox();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.CmdClearData = new System.Windows.Forms.Button();
            this.CmdGenerateSampleData = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlCustomer)).BeginInit();
            this.pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlOrders)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlCustomers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlProducts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 208);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1958, 434);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlCustomers.Controls.Add(this.pictureBoxPnlCustomer);
            this.pnlCustomers.Controls.Add(this.lblCustomersCount);
            this.pnlCustomers.Controls.Add(this.lblCustomers);
            this.pnlCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCustomers.Location = new System.Drawing.Point(4, 4);
            this.pnlCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(644, 426);
            this.pnlCustomers.TabIndex = 5;
            this.pnlCustomers.Click += new System.EventHandler(this.CmdCustomers_Click);
            // 
            // pictureBoxPnlCustomer
            // 
            this.pictureBoxPnlCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPnlCustomer.Image")));
            this.pictureBoxPnlCustomer.Location = new System.Drawing.Point(477, 280);
            this.pictureBoxPnlCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPnlCustomer.Name = "pictureBoxPnlCustomer";
            this.pictureBoxPnlCustomer.Size = new System.Drawing.Size(167, 146);
            this.pictureBoxPnlCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPnlCustomer.TabIndex = 2;
            this.pictureBoxPnlCustomer.TabStop = false;
            // 
            // lblCustomersCount
            // 
            this.lblCustomersCount.AutoEllipsis = true;
            this.lblCustomersCount.AutoSize = true;
            this.lblCustomersCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersCount.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomersCount.ForeColor = System.Drawing.Color.White;
            this.lblCustomersCount.Location = new System.Drawing.Point(38, 49);
            this.lblCustomersCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomersCount.Name = "lblCustomersCount";
            this.lblCustomersCount.Size = new System.Drawing.Size(150, 89);
            this.lblCustomersCount.TabIndex = 1;
            this.lblCustomersCount.Text = "100";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoEllipsis = true;
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomers.ForeColor = System.Drawing.Color.White;
            this.lblCustomers.Location = new System.Drawing.Point(29, 220);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(387, 89);
            this.lblCustomers.TabIndex = 0;
            this.lblCustomers.Text = "Customers";
            // 
            // pnlProducts
            // 
            this.pnlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProducts.BackColor = System.Drawing.Color.Gray;
            this.pnlProducts.Controls.Add(this.pictureBoxPnlProducts);
            this.pnlProducts.Controls.Add(this.lblProductsCount);
            this.pnlProducts.Controls.Add(this.lblProducts);
            this.pnlProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlProducts.Location = new System.Drawing.Point(656, 4);
            this.pnlProducts.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(644, 426);
            this.pnlProducts.TabIndex = 5;
            this.pnlProducts.Click += new System.EventHandler(this.CmdProducts_Click);
            // 
            // pictureBoxPnlProducts
            // 
            this.pictureBoxPnlProducts.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPnlProducts.Image")));
            this.pictureBoxPnlProducts.Location = new System.Drawing.Point(477, 280);
            this.pictureBoxPnlProducts.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPnlProducts.Name = "pictureBoxPnlProducts";
            this.pictureBoxPnlProducts.Size = new System.Drawing.Size(167, 146);
            this.pictureBoxPnlProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPnlProducts.TabIndex = 2;
            this.pictureBoxPnlProducts.TabStop = false;
            // 
            // lblProductsCount
            // 
            this.lblProductsCount.AutoEllipsis = true;
            this.lblProductsCount.AutoSize = true;
            this.lblProductsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblProductsCount.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductsCount.ForeColor = System.Drawing.Color.White;
            this.lblProductsCount.Location = new System.Drawing.Point(51, 49);
            this.lblProductsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductsCount.Name = "lblProductsCount";
            this.lblProductsCount.Size = new System.Drawing.Size(150, 89);
            this.lblProductsCount.TabIndex = 1;
            this.lblProductsCount.Text = "100";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoEllipsis = true;
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.ForeColor = System.Drawing.Color.White;
            this.lblProducts.Location = new System.Drawing.Point(26, 209);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(331, 89);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Products";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBoxPnlOrders);
            this.panel3.Controls.Add(this.lblCategoryCount);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(1308, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 426);
            this.panel3.TabIndex = 4;
            this.panel3.Click += new System.EventHandler(this.CmdProductCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categories";
            // 
            // pictureBoxPnlOrders
            // 
            this.pictureBoxPnlOrders.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPnlOrders.Image")));
            this.pictureBoxPnlOrders.Location = new System.Drawing.Point(479, 280);
            this.pictureBoxPnlOrders.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPnlOrders.Name = "pictureBoxPnlOrders";
            this.pictureBoxPnlOrders.Size = new System.Drawing.Size(167, 146);
            this.pictureBoxPnlOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPnlOrders.TabIndex = 2;
            this.pictureBoxPnlOrders.TabStop = false;
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoEllipsis = true;
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryCount.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryCount.ForeColor = System.Drawing.Color.White;
            this.lblCategoryCount.Location = new System.Drawing.Point(46, 49);
            this.lblCategoryCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(150, 89);
            this.lblCategoryCount.TabIndex = 1;
            this.lblCategoryCount.Text = "100";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.CmdClearData);
            this.pnlTop.Controls.Add(this.CmdGenerateSampleData);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(2103, 144);
            this.pnlTop.TabIndex = 8;
            // 
            // CmdClearData
            // 
            this.CmdClearData.Location = new System.Drawing.Point(985, 41);
            this.CmdClearData.Name = "CmdClearData";
            this.CmdClearData.Size = new System.Drawing.Size(470, 70);
            this.CmdClearData.TabIndex = 5;
            this.CmdClearData.Text = "Clear all Data";
            this.CmdClearData.UseVisualStyleBackColor = true;
            this.CmdClearData.Click += new System.EventHandler(this.CmdClearData_Click);
            // 
            // CmdGenerateSampleData
            // 
            this.CmdGenerateSampleData.Location = new System.Drawing.Point(1485, 45);
            this.CmdGenerateSampleData.Name = "CmdGenerateSampleData";
            this.CmdGenerateSampleData.Size = new System.Drawing.Size(415, 67);
            this.CmdGenerateSampleData.TabIndex = 4;
            this.CmdGenerateSampleData.Text = "Generate Sample Data";
            this.CmdGenerateSampleData.UseVisualStyleBackColor = true;
            this.CmdGenerateSampleData.Click += new System.EventHandler(this.CmdGenerateSampleData_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(67, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(395, 89);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Dashboard";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2103, 1211);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlCustomers.ResumeLayout(false);
            this.pnlCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlCustomer)).EndInit();
            this.pnlProducts.ResumeLayout(false);
            this.pnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlOrders)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.PictureBox pictureBoxPnlProducts;
        private System.Windows.Forms.Label lblProductsCount;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxPnlOrders;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.PictureBox pictureBoxPnlCustomer;
        private System.Windows.Forms.Label lblCustomersCount;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdGenerateSampleData;
        private System.Windows.Forms.Button CmdClearData;
    }
}

