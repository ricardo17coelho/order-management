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
            this.DataGridViewProductCategories = new System.Windows.Forms.DataGridView();
            this.TxtProductCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewProductCategories
            // 
            this.DataGridViewProductCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProductCategories.Location = new System.Drawing.Point(512, 109);
            this.DataGridViewProductCategories.Name = "DataGridViewProductCategories";
            this.DataGridViewProductCategories.RowHeadersWidth = 102;
            this.DataGridViewProductCategories.Size = new System.Drawing.Size(626, 220);
            this.DataGridViewProductCategories.TabIndex = 0;
            this.DataGridViewProductCategories.Text = "dataGridView1";
            // 
            // TxtProductCategoryName
            // 
            this.TxtProductCategoryName.Location = new System.Drawing.Point(87, 109);
            this.TxtProductCategoryName.Name = "TxtProductCategoryName";
            this.TxtProductCategoryName.Size = new System.Drawing.Size(324, 47);
            this.TxtProductCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Category Name";
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.Location = new System.Drawing.Point(87, 246);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Size = new System.Drawing.Size(250, 55);
            this.CmdAddNew.TabIndex = 3;
            this.CmdAddNew.Text = "Add New";
            this.CmdAddNew.UseVisualStyleBackColor = true;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // CrudProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 450);
            this.Controls.Add(this.CmdAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtProductCategoryName);
            this.Controls.Add(this.DataGridViewProductCategories);
            this.Name = "CrudProductCategory";
            this.Text = "CrudProductCategory";
            this.Load += new System.EventHandler(this.CrudProductCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProductCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewProductCategories;
        private System.Windows.Forms.TextBox TxtProductCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdAddNew;
    }
}