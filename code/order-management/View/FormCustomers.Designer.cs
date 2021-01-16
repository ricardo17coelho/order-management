namespace order_management.View
{
    partial class FormCustomers
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
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.StreetNr = new System.Windows.Forms.Label();
            this.TxtStreetNr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.NumZip = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(37, 70);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(478, 43);
            this.TxtFirstName.TabIndex = 0;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(570, 70);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(478, 43);
            this.TxtLastName.TabIndex = 0;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(812, 530);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(236, 72);
            this.CmdSave.TabIndex = 1;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(570, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street";
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(37, 181);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(478, 43);
            this.TxtStreet.TabIndex = 0;
            // 
            // StreetNr
            // 
            this.StreetNr.AutoSize = true;
            this.StreetNr.CausesValidation = false;
            this.StreetNr.Location = new System.Drawing.Point(570, 141);
            this.StreetNr.Name = "StreetNr";
            this.StreetNr.Size = new System.Drawing.Size(114, 37);
            this.StreetNr.TabIndex = 2;
            this.StreetNr.Text = "StreetNr";
            // 
            // TxtStreetNr
            // 
            this.TxtStreetNr.Location = new System.Drawing.Point(570, 181);
            this.TxtStreetNr.Name = "TxtStreetNr";
            this.TxtStreetNr.Size = new System.Drawing.Size(478, 43);
            this.TxtStreetNr.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Zip";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(570, 298);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(478, 43);
            this.TxtCity.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Location = new System.Drawing.Point(570, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "City";
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(37, 422);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(478, 43);
            this.TxtCountry.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Country";
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(570, 530);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(236, 72);
            this.CmdCancel.TabIndex = 1;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // NumZip
            // 
            this.NumZip.Location = new System.Drawing.Point(37, 299);
            this.NumZip.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumZip.Name = "NumZip";
            this.NumZip.Size = new System.Drawing.Size(478, 43);
            this.NumZip.TabIndex = 3;
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1128, 626);
            this.Controls.Add(this.NumZip);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtStreetNr);
            this.Controls.Add(this.StreetNr);
            this.Controls.Add(this.TxtStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Name = "FormCustomers";
            this.Text = "CustomersForm";
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.Label StreetNr;
        private System.Windows.Forms.TextBox TxtStreetNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.NumericUpDown NumZip;
    }
}