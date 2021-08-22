namespace order_management.View
{
    partial class ViewOrders
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
            this.CmdAddNew = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvOrders = new System.Windows.Forms.DataGridView();
            this.CmdGenerateBill = new System.Windows.Forms.Button();
            this.CmdViewBills = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.Location = new System.Drawing.Point(596, 642);
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
            this.CmdEdit.Location = new System.Drawing.Point(811, 642);
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
            this.CmdDelete.Location = new System.Drawing.Point(1023, 642);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(185, 79);
            this.CmdDelete.TabIndex = 1;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(68, 90);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(1140, 43);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // DgvOrders
            // 
            this.DgvOrders.AllowUserToAddRows = false;
            this.DgvOrders.AllowUserToDeleteRows = false;
            this.DgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrders.Location = new System.Drawing.Point(68, 157);
            this.DgvOrders.Name = "DgvOrders";
            this.DgvOrders.ReadOnly = true;
            this.DgvOrders.RowHeadersWidth = 92;
            this.DgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrders.Size = new System.Drawing.Size(1140, 449);
            this.DgvOrders.TabIndex = 5;
            this.DgvOrders.Text = "dataGridView1";
            this.DgvOrders.SelectionChanged += new System.EventHandler(this.DgvOrder_SelectionChanged);
            // 
            // CmdGenerateBill
            // 
            this.CmdGenerateBill.Location = new System.Drawing.Point(68, 642);
            this.CmdGenerateBill.Name = "CmdGenerateBill";
            this.CmdGenerateBill.Size = new System.Drawing.Size(187, 79);
            this.CmdGenerateBill.TabIndex = 6;
            this.CmdGenerateBill.Text = "Generate Bill";
            this.CmdGenerateBill.UseVisualStyleBackColor = true;
            this.CmdGenerateBill.Click += new System.EventHandler(this.CmdGenerateBill_Click);
            // 
            // CmdViewBills
            // 
            this.CmdViewBills.Location = new System.Drawing.Point(280, 642);
            this.CmdViewBills.Name = "CmdViewBills";
            this.CmdViewBills.Size = new System.Drawing.Size(165, 79);
            this.CmdViewBills.TabIndex = 7;
            this.CmdViewBills.Text = "Show Bills";
            this.CmdViewBills.UseVisualStyleBackColor = true;
            this.CmdViewBills.Click += new System.EventHandler(this.CmdViewBills_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 757);
            this.Controls.Add(this.CmdViewBills);
            this.Controls.Add(this.CmdGenerateBill);
            this.Controls.Add(this.DgvOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdAddNew);
            this.Name = "ViewOrders";
            this.Text = "ViewOrder";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAddNew;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvOrders;
        private System.Windows.Forms.Button CmdGenerateBill;
        private System.Windows.Forms.Button CmdViewBills;
    }
}