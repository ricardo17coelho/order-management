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
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 499);
            this.Controls.Add(this.CmdCustomers);
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdCustomers;
    }
}

