namespace order_management.View
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmdOrders = new System.Windows.Forms.Button();
            this.CmdProducts = new System.Windows.Forms.Button();
            this.CmdCategories = new System.Windows.Forms.Button();
            this.CmdYoyComparison = new System.Windows.Forms.Button();
            this.CmdCategoryTreeView = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdCustomers
            // 
            this.CmdCustomers.Location = new System.Drawing.Point(74, 74);
            this.CmdCustomers.Name = "CmdCustomers";
            this.CmdCustomers.Size = new System.Drawing.Size(204, 105);
            this.CmdCustomers.TabIndex = 0;
            this.CmdCustomers.Text = "Customers";
            this.CmdCustomers.UseVisualStyleBackColor = true;
            this.CmdCustomers.Click += new System.EventHandler(this.CmdCustomers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmdCategoryTreeView);
            this.groupBox1.Controls.Add(this.CmdYoyComparison);
            this.groupBox1.Controls.Add(this.CmdOrders);
            this.groupBox1.Controls.Add(this.CmdProducts);
            this.groupBox1.Controls.Add(this.CmdCategories);
            this.groupBox1.Controls.Add(this.CmdCustomers);
            this.groupBox1.Location = new System.Drawing.Point(36, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // CmdOrders
            // 
            this.CmdOrders.Location = new System.Drawing.Point(807, 74);
            this.CmdOrders.Name = "CmdOrders";
            this.CmdOrders.Size = new System.Drawing.Size(204, 105);
            this.CmdOrders.TabIndex = 0;
            this.CmdOrders.Text = "Orders";
            this.CmdOrders.UseVisualStyleBackColor = true;
            // 
            // CmdProducts
            // 
            this.CmdProducts.Location = new System.Drawing.Point(557, 74);
            this.CmdProducts.Name = "CmdProducts";
            this.CmdProducts.Size = new System.Drawing.Size(204, 105);
            this.CmdProducts.TabIndex = 0;
            this.CmdProducts.Text = "Products";
            this.CmdProducts.UseVisualStyleBackColor = true;
            this.CmdProducts.Click += new System.EventHandler(this.CmdProducts_Click);
            // 
            // CmdCategories
            // 
            this.CmdCategories.Location = new System.Drawing.Point(314, 74);
            this.CmdCategories.Name = "CmdCategories";
            this.CmdCategories.Size = new System.Drawing.Size(204, 105);
            this.CmdCategories.TabIndex = 0;
            this.CmdCategories.Text = "Categories";
            this.CmdCategories.UseVisualStyleBackColor = true;
            this.CmdCategories.Click += new System.EventHandler(this.CmdCategories_Click);
            // 
            // CmdYoyComparison
            // 
            this.CmdYoyComparison.Location = new System.Drawing.Point(557, 212);
            this.CmdYoyComparison.Name = "CmdYoyComparison";
            this.CmdYoyComparison.Size = new System.Drawing.Size(204, 105);
            this.CmdYoyComparison.TabIndex = 0;
            this.CmdYoyComparison.Text = "YOY Comparison";
            this.CmdYoyComparison.UseVisualStyleBackColor = true;
            // 
            // CmdCategoryTreeView
            // 
            this.CmdCategoryTreeView.Location = new System.Drawing.Point(314, 212);
            this.CmdCategoryTreeView.Name = "CmdCategoryTreeView";
            this.CmdCategoryTreeView.Size = new System.Drawing.Size(204, 105);
            this.CmdCategoryTreeView.TabIndex = 0;
            this.CmdCategoryTreeView.Text = "Category Treeview";
            this.CmdCategoryTreeView.UseVisualStyleBackColor = true;
            this.CmdCategoryTreeView.Click += new System.EventHandler(this.CmdCategoryTreeView_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 673);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomeScreen";
            this.Text = "Home";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CmdOrders;
        private System.Windows.Forms.Button CmdProducts;
        private System.Windows.Forms.Button CmdCategories;
        private System.Windows.Forms.Button CmdYoyComparison;
        private System.Windows.Forms.Button CmdCategoryTreeView;
    }
}