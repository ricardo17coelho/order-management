namespace order_management.View
{
    partial class ViewBills
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
            this.DgvBills = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBills
            // 
            this.DgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBills.Location = new System.Drawing.Point(58, 53);
            this.DgvBills.Name = "DgvBills";
            this.DgvBills.RowHeadersWidth = 92;
            this.DgvBills.Size = new System.Drawing.Size(2724, 755);
            this.DgvBills.TabIndex = 0;
            this.DgvBills.Text = "dataGridView1";
            // 
            // ViewBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2838, 856);
            this.Controls.Add(this.DgvBills);
            this.Name = "ViewBills";
            this.Text = "Bills";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBills;
    }
}