namespace order_management.View
{
    partial class FormCategories
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
            this.TxtCategoryName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CbParentCategory = new System.Windows.Forms.ComboBox();
            this.CkbRootCategory = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.Location = new System.Drawing.Point(22, 62);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(478, 43);
            this.TxtCategoryName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(797, 522);
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
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Location = new System.Drawing.Point(18, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parent Category";
            // 
            // CbParentCategory
            // 
            this.CbParentCategory.FormattingEnabled = true;
            this.CbParentCategory.Location = new System.Drawing.Point(26, 183);
            this.CbParentCategory.Name = "CbParentCategory";
            this.CbParentCategory.Size = new System.Drawing.Size(470, 45);
            this.CbParentCategory.TabIndex = 4;
            // 
            // CkbRootCategory
            // 
            this.CkbRootCategory.AutoSize = true;
            this.CkbRootCategory.Location = new System.Drawing.Point(555, 62);
            this.CkbRootCategory.Name = "CkbRootCategory";
            this.CkbRootCategory.Size = new System.Drawing.Size(220, 41);
            this.CkbRootCategory.TabIndex = 5;
            this.CkbRootCategory.Text = "Root Category";
            this.CkbRootCategory.UseVisualStyleBackColor = true;
            this.CkbRootCategory.CheckedChanged += new System.EventHandler(this.CkbNewRootCategory_CheckedChanged);
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 617);
            this.Controls.Add(this.CkbRootCategory);
            this.Controls.Add(this.CbParentCategory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCategoryName);
            this.Name = "FormCategories";
            this.Text = "FormCategories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCategoryName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbParentCategory;
        private System.Windows.Forms.CheckBox CkbRootCategory;
    }
}