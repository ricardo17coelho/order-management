namespace order_management.View
{
    partial class FormProducts
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
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.NumPrice = new System.Windows.Forms.NumericUpDown();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(27, 77);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(478, 43);
            this.TxtProductName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 537);
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
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(560, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit";
            // 
            // TxtUnit
            // 
            this.TxtUnit.Location = new System.Drawing.Point(27, 188);
            this.TxtUnit.Name = "TxtUnit";
            this.TxtUnit.Size = new System.Drawing.Size(478, 43);
            this.TxtUnit.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(560, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Introduction Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Category";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // NumPrice
            // 
            this.NumPrice.Location = new System.Drawing.Point(560, 77);
            this.NumPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumPrice.Name = "NumPrice";
            this.NumPrice.Size = new System.Drawing.Size(478, 43);
            this.NumPrice.TabIndex = 3;
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(27, 305);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(478, 45);
            this.CbCategory.TabIndex = 4;
            // 
            // DtpDate
            // 
            this.DtpDate.Location = new System.Drawing.Point(560, 188);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(478, 43);
            this.DtpDate.TabIndex = 5;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 647);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.CbCategory);
            this.Controls.Add(this.NumPrice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtProductName);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown NumPrice;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.DateTimePicker DtpDate;
    }
}