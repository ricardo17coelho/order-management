namespace order_management.View
{
    partial class ViewCategoryTreeView
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
            this.TvCategories = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // TvCategories
            // 
            this.TvCategories.Location = new System.Drawing.Point(28, 31);
            this.TvCategories.Name = "TvCategories";
            this.TvCategories.Size = new System.Drawing.Size(1051, 775);
            this.TvCategories.TabIndex = 0;
            // 
            // ViewCategoryTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 864);
            this.Controls.Add(this.TvCategories);
            this.Name = "ViewCategoryTreeView";
            this.Text = "ViewCategoryTreeView";
            this.Load += new System.EventHandler(this.ViewCategoryTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TvCategories;
    }
}