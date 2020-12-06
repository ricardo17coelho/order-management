namespace order_management
{
    partial class CrudCustomers
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
            this.DataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.CmdSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewCustomers
            // 
            this.DataGridViewCustomers.AllowDrop = true;
            this.DataGridViewCustomers.AllowUserToOrderColumns = true;
            this.DataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCustomers.Location = new System.Drawing.Point(342, 79);
            this.DataGridViewCustomers.Name = "DataGridViewCustomers";
            this.DataGridViewCustomers.RowHeadersWidth = 102;
            this.DataGridViewCustomers.Size = new System.Drawing.Size(823, 378);
            this.DataGridViewCustomers.TabIndex = 0;
            this.DataGridViewCustomers.Text = "dataGridView1";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(940, 12);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(201, 51);
            this.CmdSave.TabIndex = 1;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2580, 1925);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(23, 318);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(288, 58);
            this.CmdAdd.TabIndex = 2;
            this.CmdAdd.Text = "Add New";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(23, 79);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(273, 47);
            this.TxtFirstName.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-9720, -1435);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(2583, 47);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1045, 635);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1708, 47);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(20, -983);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(10675, 47);
            this.textBox4.TabIndex = 3;
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(23, 230);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(273, 47);
            this.TxtStreet.TabIndex = 5;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(23, 155);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(273, 47);
            this.TxtLastName.TabIndex = 6;
            // 
            // CrudCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 676);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtStreet);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.DataGridViewCustomers);
            this.Name = "CrudCustomers";
            this.Text = "CrudCustomer";
            this.Load += new System.EventHandler(this.CrudCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewCustomers;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.TextBox TxtLastName;
    }
}