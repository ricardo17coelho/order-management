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
            this.CmdCustomers = new System.Windows.Forms.Button();
            this.CmdGenerateSampleData = new System.Windows.Forms.Button();
            this.CmdProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdCustomers
            // 
            this.CmdCustomers.Location = new System.Drawing.Point(35, 45);
            this.CmdCustomers.Name = "CmdCustomers";
            this.CmdCustomers.Size = new System.Drawing.Size(234, 75);
            this.CmdCustomers.TabIndex = 0;
            this.CmdCustomers.Text = "Customers";
            this.CmdCustomers.UseVisualStyleBackColor = true;
            this.CmdCustomers.Click += new System.EventHandler(this.CmdCustomers_Click);
            // 
            // CmdGenerateSampleData
            // 
            this.CmdGenerateSampleData.Location = new System.Drawing.Point(365, 45);
            this.CmdGenerateSampleData.Name = "CmdGenerateSampleData";
            this.CmdGenerateSampleData.Size = new System.Drawing.Size(274, 97);
            this.CmdGenerateSampleData.TabIndex = 1;
            this.CmdGenerateSampleData.Text = "Generate Sample Data";
            this.CmdGenerateSampleData.UseVisualStyleBackColor = true;
            this.CmdGenerateSampleData.Click += new System.EventHandler(this.CmdGenerateSampleData_Click);
            // 
            // CmdProducts
            // 
            this.CmdProducts.Location = new System.Drawing.Point(35, 168);
            this.CmdProducts.Name = "CmdProducts";
            this.CmdProducts.Size = new System.Drawing.Size(221, 89);
            this.CmdProducts.TabIndex = 2;
            this.CmdProducts.Text = "Products";
            this.CmdProducts.UseVisualStyleBackColor = true;
            this.CmdProducts.Click += new System.EventHandler(this.CmdProducts_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 646);
            this.Controls.Add(this.CmdProducts);
            this.Controls.Add(this.CmdGenerateSampleData);
            this.Controls.Add(this.CmdCustomers);
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdCustomers;
        private System.Windows.Forms.Button CmdGenerateSampleData;
        private System.Windows.Forms.Button CmdProducts;
    }
}

