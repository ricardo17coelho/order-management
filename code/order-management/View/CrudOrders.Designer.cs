namespace order_management.View
{
    partial class CrudOrders
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
            this.DataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.DataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.CbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.NumQuantity = new System.Windows.Forms.NumericUpDown();
            this.CbProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbProductCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdOrder = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdSaveOrders = new System.Windows.Forms.Button();
            this.CmdDeleteOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewOrders
            // 
            this.DataGridViewOrders.AllowUserToAddRows = false;
            this.DataGridViewOrders.AllowUserToDeleteRows = false;
            this.DataGridViewOrders.AllowUserToOrderColumns = true;
            this.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOrders.Location = new System.Drawing.Point(991, 85);
            this.DataGridViewOrders.Name = "DataGridViewOrders";
            this.DataGridViewOrders.RowHeadersWidth = 102;
            this.DataGridViewOrders.Size = new System.Drawing.Size(814, 379);
            this.DataGridViewOrders.TabIndex = 0;
            this.DataGridViewOrders.Text = "dataGridView1";
            // 
            // DataGridViewOrderDetails
            // 
            this.DataGridViewOrderDetails.AllowUserToAddRows = false;
            this.DataGridViewOrderDetails.AllowUserToDeleteRows = false;
            this.DataGridViewOrderDetails.AllowUserToOrderColumns = true;
            this.DataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOrderDetails.Location = new System.Drawing.Point(991, 588);
            this.DataGridViewOrderDetails.Name = "DataGridViewOrderDetails";
            this.DataGridViewOrderDetails.RowHeadersWidth = 102;
            this.DataGridViewOrderDetails.Size = new System.Drawing.Size(814, 308);
            this.DataGridViewOrderDetails.TabIndex = 0;
            this.DataGridViewOrderDetails.Text = "dataGridView1";
            // 
            // CbCustomer
            // 
            this.CbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCustomer.FormattingEnabled = true;
            this.CbCustomer.Location = new System.Drawing.Point(70, 142);
            this.CbCustomer.Name = "CbCustomer";
            this.CbCustomer.Size = new System.Drawing.Size(335, 49);
            this.CbCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(70, 388);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(132, 41);
            this.Quantity.TabIndex = 2;
            this.Quantity.Text = "Quantity";
            // 
            // NumQuantity
            // 
            this.NumQuantity.Location = new System.Drawing.Point(70, 454);
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(335, 47);
            this.NumQuantity.TabIndex = 3;
            // 
            // CbProduct
            // 
            this.CbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProduct.FormattingEnabled = true;
            this.CbProduct.Location = new System.Drawing.Point(461, 288);
            this.CbProduct.Name = "CbProduct";
            this.CbProduct.Size = new System.Drawing.Size(335, 49);
            this.CbProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product";
            // 
            // CbProductCategory
            // 
            this.CbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProductCategory.FormattingEnabled = true;
            this.CbProductCategory.Location = new System.Drawing.Point(70, 288);
            this.CbProductCategory.Name = "CbProductCategory";
            this.CbProductCategory.Size = new System.Drawing.Size(335, 49);
            this.CbProductCategory.TabIndex = 1;
            this.CbProductCategory.SelectedIndexChanged += new System.EventHandler(this.CbProductCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Category";
            // 
            // CmdOrder
            // 
            this.CmdOrder.Location = new System.Drawing.Point(70, 588);
            this.CmdOrder.Name = "CmdOrder";
            this.CmdOrder.Size = new System.Drawing.Size(188, 58);
            this.CmdOrder.TabIndex = 4;
            this.CmdOrder.Text = "Order";
            this.CmdOrder.UseVisualStyleBackColor = true;
            this.CmdOrder.Click += new System.EventHandler(this.CmdOrder_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(1523, 971);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(281, 60);
            this.CmdSave.TabIndex = 5;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(1183, 971);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(281, 60);
            this.CmdDelete.TabIndex = 5;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdSaveOrders
            // 
            this.CmdSaveOrders.Location = new System.Drawing.Point(1524, 483);
            this.CmdSaveOrders.Name = "CmdSaveOrders";
            this.CmdSaveOrders.Size = new System.Drawing.Size(281, 60);
            this.CmdSaveOrders.TabIndex = 5;
            this.CmdSaveOrders.Text = "Save";
            this.CmdSaveOrders.UseVisualStyleBackColor = true;
            this.CmdSaveOrders.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDeleteOrders
            // 
            this.CmdDeleteOrders.Location = new System.Drawing.Point(1184, 483);
            this.CmdDeleteOrders.Name = "CmdDeleteOrders";
            this.CmdDeleteOrders.Size = new System.Drawing.Size(281, 60);
            this.CmdDeleteOrders.TabIndex = 5;
            this.CmdDeleteOrders.Text = "Delete";
            this.CmdDeleteOrders.UseVisualStyleBackColor = true;
            this.CmdDeleteOrders.Click += new System.EventHandler(this.CmdDeleteOrders_Click);
            // 
            // CrudOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 1078);
            this.Controls.Add(this.CmdDeleteOrders);
            this.Controls.Add(this.CmdSaveOrders);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbProductCategory);
            this.Controls.Add(this.NumQuantity);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbCustomer);
            this.Controls.Add(this.DataGridViewOrderDetails);
            this.Controls.Add(this.DataGridViewOrders);
            this.Name = "CrudOrders";
            this.Text = "CrudOrders";
            this.Load += new System.EventHandler(this.CrudOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewOrders;
        private System.Windows.Forms.DataGridView DataGridViewOrderDetails;
        private System.Windows.Forms.ComboBox CbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.NumericUpDown NumQuantity;
        private System.Windows.Forms.ComboBox CbProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbProductCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdOrder;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdSaveOrders;
        private System.Windows.Forms.Button CmdDeleteOrders;
    }
}