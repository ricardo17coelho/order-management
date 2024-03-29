﻿namespace order_management.View
{
    partial class HomeScreen
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
            this.CmdCustomers = new System.Windows.Forms.Button();
            this.CmdCategoryTreeView = new System.Windows.Forms.Button();
            this.CmdBills = new System.Windows.Forms.Button();
            this.CmdOrders = new System.Windows.Forms.Button();
            this.CmdProducts = new System.Windows.Forms.Button();
            this.CmdCategories = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.CmdExport = new System.Windows.Forms.Button();
            this.CmdImport = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdCustomers
            // 
            this.CmdCustomers.Location = new System.Drawing.Point(1, 1);
            this.CmdCustomers.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CmdCustomers.Name = "CmdCustomers";
            this.CmdCustomers.Size = new System.Drawing.Size(95, 43);
            this.CmdCustomers.TabIndex = 0;
            this.CmdCustomers.Text = "Customers";
            this.CmdCustomers.UseVisualStyleBackColor = true;
            this.CmdCustomers.Click += new System.EventHandler(this.CmdCustomers_Click);
            // 
            // CmdCategoryTreeView
            // 
            this.CmdCategoryTreeView.Location = new System.Drawing.Point(389, 1);
            this.CmdCategoryTreeView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CmdCategoryTreeView.Name = "CmdCategoryTreeView";
            this.CmdCategoryTreeView.Size = new System.Drawing.Size(95, 43);
            this.CmdCategoryTreeView.TabIndex = 0;
            this.CmdCategoryTreeView.Text = "Category Treeview";
            this.CmdCategoryTreeView.UseVisualStyleBackColor = true;
            this.CmdCategoryTreeView.Click += new System.EventHandler(this.CmdCategoryTreeView_Click);
            // 
            // CmdBills
            // 
            this.CmdBills.Location = new System.Drawing.Point(583, 1);
            this.CmdBills.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CmdBills.Name = "CmdBills";
            this.CmdBills.Size = new System.Drawing.Size(95, 43);
            this.CmdBills.TabIndex = 0;
            this.CmdBills.Text = "Bills";
            this.CmdBills.UseVisualStyleBackColor = true;
            this.CmdBills.Click += new System.EventHandler(this.CmdBills_Click);
            // 
            // CmdOrders
            // 
            this.CmdOrders.Location = new System.Drawing.Point(292, 1);
            this.CmdOrders.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CmdOrders.Name = "CmdOrders";
            this.CmdOrders.Size = new System.Drawing.Size(95, 43);
            this.CmdOrders.TabIndex = 0;
            this.CmdOrders.Text = "Orders";
            this.CmdOrders.UseVisualStyleBackColor = true;
            this.CmdOrders.Click += new System.EventHandler(this.CmdOrders_Click);
            // 
            // CmdProducts
            // 
            this.CmdProducts.Location = new System.Drawing.Point(195, 1);
            this.CmdProducts.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CmdProducts.Name = "CmdProducts";
            this.CmdProducts.Size = new System.Drawing.Size(95, 43);
            this.CmdProducts.TabIndex = 0;
            this.CmdProducts.Text = "Products";
            this.CmdProducts.UseVisualStyleBackColor = true;
            this.CmdProducts.Click += new System.EventHandler(this.CmdProducts_Click);
            // 
            // CmdCategories
            // 
            this.CmdCategories.Location = new System.Drawing.Point(98, 1);
            this.CmdCategories.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CmdCategories.Name = "CmdCategories";
            this.CmdCategories.Size = new System.Drawing.Size(95, 43);
            this.CmdCategories.TabIndex = 0;
            this.CmdCategories.Text = "Categories";
            this.CmdCategories.UseVisualStyleBackColor = true;
            this.CmdCategories.Click += new System.EventHandler(this.CmdCategories_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.CmdCustomers);
            this.flowLayoutPanel1.Controls.Add(this.CmdCategories);
            this.flowLayoutPanel1.Controls.Add(this.CmdProducts);
            this.flowLayoutPanel1.Controls.Add(this.CmdOrders);
            this.flowLayoutPanel1.Controls.Add(this.CmdCategoryTreeView);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.CmdBills);
            this.flowLayoutPanel1.Controls.Add(this.CmdExport);
            this.flowLayoutPanel1.Controls.Add(this.CmdImport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 14);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(696, 256);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "YOY Comparison";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CmdYoyComparison_Click);
            // 
            // CmdExport
            // 
            this.CmdExport.Location = new System.Drawing.Point(1, 46);
            this.CmdExport.Margin = new System.Windows.Forms.Padding(1);
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(95, 43);
            this.CmdExport.TabIndex = 1;
            this.CmdExport.Text = "Export";
            this.CmdExport.UseVisualStyleBackColor = true;
            this.CmdExport.Click += new System.EventHandler(this.CmdExport_Click);
            // 
            // CmdImport
            // 
            this.CmdImport.Location = new System.Drawing.Point(98, 46);
            this.CmdImport.Margin = new System.Windows.Forms.Padding(1);
            this.CmdImport.Name = "CmdImport";
            this.CmdImport.Size = new System.Drawing.Size(95, 43);
            this.CmdImport.TabIndex = 2;
            this.CmdImport.Text = "Import";
            this.CmdImport.UseVisualStyleBackColor = true;
            this.CmdImport.Click += new System.EventHandler(this.CmdImport_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 285);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "HomeScreen";
            this.Text = "Home";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdCustomers;
        private System.Windows.Forms.Button CmdOrders;
        private System.Windows.Forms.Button CmdProducts;
        private System.Windows.Forms.Button CmdCategories;
        private System.Windows.Forms.Button CmdBills;
        private System.Windows.Forms.Button CmdCategoryTreeView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button CmdExport;
		private System.Windows.Forms.Button CmdImport;
	}
}