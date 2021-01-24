namespace order_management.View
{
    partial class ViewYoyComparison
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
            this.DgvYoy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvYoy)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvYoy
            // 
            this.DgvYoy.AllowUserToAddRows = false;
            this.DgvYoy.AllowUserToDeleteRows = false;
            this.DgvYoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvYoy.Location = new System.Drawing.Point(39, 31);
            this.DgvYoy.Name = "DgvYoy";
            this.DgvYoy.RowHeadersWidth = 92;
            this.DgvYoy.Size = new System.Drawing.Size(1446, 645);
            this.DgvYoy.TabIndex = 0;
            this.DgvYoy.Text = "dataGridView1";
            // 
            // ViewYoyComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 727);
            this.Controls.Add(this.DgvYoy);
            this.Name = "ViewYoyComparison";
            this.Text = "ViewYoyComparison";
            ((System.ComponentModel.ISupportInitialize)(this.DgvYoy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvYoy;
    }
}