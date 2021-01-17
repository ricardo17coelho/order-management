namespace order_management.View
{
    partial class FormOrders
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CbCustomer = new System.Windows.Forms.ComboBox();
            this.DtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.NumTax = new System.Windows.Forms.NumericUpDown();
            this.DgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.CmdAddNew = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(942, 1211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(676, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Order Date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 1211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CbCustomer
            // 
            this.CbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCustomer.FormattingEnabled = true;
            this.CbCustomer.Location = new System.Drawing.Point(48, 84);
            this.CbCustomer.Name = "CbCustomer";
            this.CbCustomer.Size = new System.Drawing.Size(478, 45);
            this.CbCustomer.TabIndex = 4;
            // 
            // DtpOrderDate
            // 
            this.DtpOrderDate.Location = new System.Drawing.Point(676, 84);
            this.DtpOrderDate.Name = "DtpOrderDate";
            this.DtpOrderDate.Size = new System.Drawing.Size(478, 43);
            this.DtpOrderDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tax";
            // 
            // NumTax
            // 
            this.NumTax.DecimalPlaces = 1;
            this.NumTax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumTax.Location = new System.Drawing.Point(48, 180);
            this.NumTax.Name = "NumTax";
            this.NumTax.Size = new System.Drawing.Size(478, 43);
            this.NumTax.TabIndex = 6;
            // 
            // DgvOrderDetails
            // 
            this.DgvOrderDetails.AllowUserToAddRows = false;
            this.DgvOrderDetails.AllowUserToDeleteRows = false;
            this.DgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderDetails.Location = new System.Drawing.Point(38, 436);
            this.DgvOrderDetails.Name = "DgvOrderDetails";
            this.DgvOrderDetails.ReadOnly = true;
            this.DgvOrderDetails.RowHeadersWidth = 92;
            this.DgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrderDetails.Size = new System.Drawing.Size(1140, 449);
            this.DgvOrderDetails.TabIndex = 5;
            this.DgvOrderDetails.Text = "dataGridView1";
            this.DgvOrderDetails.SelectionChanged += new System.EventHandler(this.DgvOrderDetails_SelectionChanged);
            // 
            // CmdAddNew
            // 
            this.CmdAddNew.Location = new System.Drawing.Point(566, 921);
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
            this.CmdEdit.Location = new System.Drawing.Point(781, 921);
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
            this.CmdDelete.Location = new System.Drawing.Point(993, 921);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(185, 79);
            this.CmdDelete.TabIndex = 1;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Positions";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 1305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdAddNew);
            this.Controls.Add(this.DgvOrderDetails);
            this.Controls.Add(this.NumTax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpOrderDate);
            this.Controls.Add(this.CbCustomer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            ((System.ComponentModel.ISupportInitialize)(this.NumTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CbCustomer;
        private System.Windows.Forms.DateTimePicker DtpOrderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumTax;
        private System.Windows.Forms.DataGridView DgvOrderDetails;
        private System.Windows.Forms.Button CmdAddNew;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Label label3;
    }
}