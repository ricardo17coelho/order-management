namespace order_management.View
{
    partial class ViewCategories
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
            this.DgvCategories = new System.Windows.Forms.DataGridView();
            this.CmdAddNew = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCategories
            // 
            this.DgvCategories.AllowUserToAddRows = false;
            this.DgvCategories.AllowUserToDeleteRows = false;
            this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategories.Location = new System.Drawing.Point(57, 176);
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.ReadOnly = true;
            this.DgvCategories.RowHeadersWidth = 92;
            this.DgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCategories.Size = new System.Drawing.Size(1140, 449);
            this.DgvCategories.TabIndex = 5;
            this.DgvCategories.Text = "dataGridView1";
            this.DgvCategories.SelectionChanged += new System.EventHandler(this.DgvCategories_SelectionChanged);
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.Location = new System.Drawing.Point(585, 661);
            this.CmdAddNew.Name = "CmdAddNew";
            this.CmdAddNew.Size = new System.Drawing.Size(185, 79);
            this.CmdAddNew.TabIndex = 1;
            this.CmdAddNew.Text = "Add New";
            this.CmdAddNew.UseVisualStyleBackColor = true;
            this.CmdAddNew.Click += new System.EventHandler(this.CmdAddNew_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Enabled = false;
            this.CmdEdit.Location = new System.Drawing.Point(800, 661);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(185, 79);
            this.CmdEdit.TabIndex = 1;
            this.CmdEdit.Text = "Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Enabled = false;
            this.CmdDelete.Location = new System.Drawing.Point(1012, 661);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(185, 79);
            this.CmdDelete.TabIndex = 1;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(57, 109);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(1140, 43);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // ViewCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdAddNew);
            this.Controls.Add(this.DgvCategories);
            this.Name = "ViewCategories";
            this.Text = "ViewCategories";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCategories;
        private System.Windows.Forms.Button CmdAddNew;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
    }
}