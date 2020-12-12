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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NumZip = new System.Windows.Forms.NumericUpDown();
            this.TxtStreetNr = new System.Windows.Forms.TextBox();
            this.CmdDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewCustomers
            // 
            this.DataGridViewCustomers.AllowDrop = true;
            this.DataGridViewCustomers.AllowUserToOrderColumns = true;
            this.DataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCustomers.Location = new System.Drawing.Point(509, 91);
            this.DataGridViewCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridViewCustomers.Name = "DataGridViewCustomers";
            this.DataGridViewCustomers.RowHeadersWidth = 102;
            this.DataGridViewCustomers.Size = new System.Drawing.Size(629, 295);
            this.DataGridViewCustomers.TabIndex = 0;
            this.DataGridViewCustomers.Text = "dataGridView1";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(984, 403);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(154, 40);
            this.CmdSave.TabIndex = 1;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1973, 1502);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CmdAdd
            // 
            this.CmdAdd.Location = new System.Drawing.Point(18, 657);
            this.CmdAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(220, 45);
            this.CmdAdd.TabIndex = 2;
            this.CmdAdd.Text = "Add New";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(18, 63);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(210, 39);
            this.TxtFirstName.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-7433, -1120);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1976, 39);
            this.textBox2.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, -767);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(8164, 39);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lastname";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(18, 149);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(210, 39);
            this.TxtLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Street";
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(18, 237);
            this.TxtStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(210, 39);
            this.TxtStreet.TabIndex = 3;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(18, 500);
            this.TxtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(210, 39);
            this.TxtCity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "StreetNr";
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(18, 576);
            this.TxtCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(210, 39);
            this.TxtCountry.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 542);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "Country";
            // 
            // NumZip
            // 
            this.NumZip.Location = new System.Drawing.Point(18, 426);
            this.NumZip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumZip.Name = "NumZip";
            this.NumZip.Size = new System.Drawing.Size(209, 39);
            this.NumZip.TabIndex = 8;
            // 
            // TxtStreetNr
            // 
            this.TxtStreetNr.Location = new System.Drawing.Point(18, 332);
            this.TxtStreetNr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtStreetNr.Name = "TxtStreetNr";
            this.TxtStreetNr.Size = new System.Drawing.Size(210, 39);
            this.TxtStreetNr.TabIndex = 3;
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(808, 403);
            this.CmdDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(154, 40);
            this.CmdDelete.TabIndex = 1;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CrudCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 742);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.NumZip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtStreetNr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.DataGridViewCustomers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrudCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrudCustomer";
            this.Load += new System.EventHandler(this.CrudCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).EndInit();
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumZip;
        private System.Windows.Forms.TextBox TxtStreetNr;
        private System.Windows.Forms.Button CmdDelete;
    }
}