namespace order_management.View
{
    partial class YOYComparison
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
            this.DataGridViewYOY = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewYOY)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewYOY
            // 
            this.DataGridViewYOY.AllowUserToAddRows = false;
            this.DataGridViewYOY.AllowUserToDeleteRows = false;
            this.DataGridViewYOY.AllowUserToResizeColumns = false;
            this.DataGridViewYOY.AllowUserToResizeRows = false;
            this.DataGridViewYOY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewYOY.Location = new System.Drawing.Point(42, 57);
            this.DataGridViewYOY.Name = "DataGridViewYOY";
            this.DataGridViewYOY.RowHeadersWidth = 82;
            this.DataGridViewYOY.Size = new System.Drawing.Size(1099, 521);
            this.DataGridViewYOY.TabIndex = 0;
            this.DataGridViewYOY.Text = "dataGridView1";
            // 
            // YOYComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 651);
            this.Controls.Add(this.DataGridViewYOY);
            this.Name = "YOYComparison";
            this.Text = "YOYComparison";
            this.Load += new System.EventHandler(this.YOYComparison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewYOY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewYOY;
    }
}