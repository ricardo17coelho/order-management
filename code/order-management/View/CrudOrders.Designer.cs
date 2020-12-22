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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudOrders));
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
            this.lblTitleOrders = new System.Windows.Forms.Label();
            this.pictureBoxPnlProducts = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewOrders
            // 
            this.DataGridViewOrders.AllowUserToAddRows = false;
            this.DataGridViewOrders.AllowUserToDeleteRows = false;
            this.DataGridViewOrders.AllowUserToOrderColumns = true;
            this.DataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOrders.Location = new System.Drawing.Point(2, 2);
            this.DataGridViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewOrders.Name = "DataGridViewOrders";
            this.DataGridViewOrders.RowHeadersWidth = 102;
            this.DataGridViewOrders.Size = new System.Drawing.Size(652, 267);
            this.DataGridViewOrders.TabIndex = 0;
            this.DataGridViewOrders.Text = "dataGridView1";
            // 
            // DataGridViewOrderDetails
            // 
            this.DataGridViewOrderDetails.AllowUserToAddRows = false;
            this.DataGridViewOrderDetails.AllowUserToDeleteRows = false;
            this.DataGridViewOrderDetails.AllowUserToOrderColumns = true;
            this.DataGridViewOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOrderDetails.Location = new System.Drawing.Point(2, 370);
            this.DataGridViewOrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewOrderDetails.Name = "DataGridViewOrderDetails";
            this.DataGridViewOrderDetails.RowHeadersWidth = 102;
            this.DataGridViewOrderDetails.Size = new System.Drawing.Size(652, 339);
            this.DataGridViewOrderDetails.TabIndex = 0;
            this.DataGridViewOrderDetails.Text = "dataGridView1";
            // 
            // CbCustomer
            // 
            this.CbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCustomer.FormattingEnabled = true;
            this.CbCustomer.Location = new System.Drawing.Point(327, 2);
            this.CbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.CbCustomer.Name = "CbCustomer";
            this.CbCustomer.Size = new System.Drawing.Size(196, 40);
            this.CbCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(2, 252);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(106, 32);
            this.Quantity.TabIndex = 2;
            this.Quantity.Text = "Quantity";
            // 
            // NumQuantity
            // 
            this.NumQuantity.Location = new System.Drawing.Point(327, 254);
            this.NumQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(196, 39);
            this.NumQuantity.TabIndex = 3;
            // 
            // CbProduct
            // 
            this.CbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProduct.FormattingEnabled = true;
            this.CbProduct.Location = new System.Drawing.Point(327, 196);
            this.CbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.CbProduct.Name = "CbProduct";
            this.CbProduct.Size = new System.Drawing.Size(196, 40);
            this.CbProduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product";
            // 
            // CbProductCategory
            // 
            this.CbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProductCategory.FormattingEnabled = true;
            this.CbProductCategory.Location = new System.Drawing.Point(327, 99);
            this.CbProductCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CbProductCategory.Name = "CbProductCategory";
            this.CbProductCategory.Size = new System.Drawing.Size(196, 40);
            this.CbProductCategory.TabIndex = 1;
            this.CbProductCategory.SelectedIndexChanged += new System.EventHandler(this.CbProductCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Category";
            // 
            // CmdOrder
            // 
            this.CmdOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.CmdOrder.Location = new System.Drawing.Point(2, 2);
            this.CmdOrder.Margin = new System.Windows.Forms.Padding(2);
            this.CmdOrder.Name = "CmdOrder";
            this.CmdOrder.Size = new System.Drawing.Size(217, 62);
            this.CmdOrder.TabIndex = 4;
            this.CmdOrder.Text = "Place Order";
            this.CmdOrder.UseVisualStyleBackColor = false;
            this.CmdOrder.Click += new System.EventHandler(this.CmdOrder_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(202, 2);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(196, 47);
            this.CmdSave.TabIndex = 5;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(2, 2);
            this.CmdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(196, 47);
            this.CmdDelete.TabIndex = 5;
            this.CmdDelete.Text = "Delete";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdSaveOrders
            // 
            this.CmdSaveOrders.Location = new System.Drawing.Point(205, 2);
            this.CmdSaveOrders.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSaveOrders.Name = "CmdSaveOrders";
            this.CmdSaveOrders.Size = new System.Drawing.Size(196, 47);
            this.CmdSaveOrders.TabIndex = 5;
            this.CmdSaveOrders.Text = "Save";
            this.CmdSaveOrders.UseVisualStyleBackColor = true;
            this.CmdSaveOrders.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdDeleteOrders
            // 
            this.CmdDeleteOrders.Location = new System.Drawing.Point(2, 2);
            this.CmdDeleteOrders.Margin = new System.Windows.Forms.Padding(2);
            this.CmdDeleteOrders.Name = "CmdDeleteOrders";
            this.CmdDeleteOrders.Size = new System.Drawing.Size(196, 47);
            this.CmdDeleteOrders.TabIndex = 5;
            this.CmdDeleteOrders.Text = "Delete";
            this.CmdDeleteOrders.UseVisualStyleBackColor = true;
            this.CmdDeleteOrders.Click += new System.EventHandler(this.CmdDeleteOrders_Click);
            // 
            // lblTitleOrders
            // 
            this.lblTitleOrders.AutoEllipsis = true;
            this.lblTitleOrders.AutoSize = true;
            this.lblTitleOrders.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleOrders.ForeColor = System.Drawing.Color.White;
            this.lblTitleOrders.Location = new System.Drawing.Point(129, 0);
            this.lblTitleOrders.Name = "lblTitleOrders";
            this.lblTitleOrders.Size = new System.Drawing.Size(274, 93);
            this.lblTitleOrders.TabIndex = 3;
            this.lblTitleOrders.Text = "Orders";
            this.lblTitleOrders.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pictureBoxPnlProducts
            // 
            this.pictureBoxPnlProducts.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPnlProducts.Image")));
            this.pictureBoxPnlProducts.Location = new System.Drawing.Point(6, -2);
            this.pictureBoxPnlProducts.Name = "pictureBoxPnlProducts";
            this.pictureBoxPnlProducts.Size = new System.Drawing.Size(128, 114);
            this.pictureBoxPnlProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPnlProducts.TabIndex = 4;
            this.pictureBoxPnlProducts.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblTitleOrders);
            this.pnlTop.Controls.Add(this.pictureBoxPnlProducts);
            this.pnlTop.Location = new System.Drawing.Point(12, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1330, 112);
            this.pnlTop.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 147);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1324, 791);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DataGridViewOrders, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.DataGridViewOrderDetails, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(665, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(656, 785);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.CmdDeleteOrders, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CmdSaveOrders, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 274);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(406, 91);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.CmdDelete, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.CmdSave, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 714);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(400, 68);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.60509F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.39491F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(656, 785);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.CmdOrder, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 361);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(400, 120);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.CbCustomer, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.CbProductCategory, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.CbProduct, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.NumQuantity, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.Quantity, 0, 3);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(650, 336);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // CrudOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1354, 950);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrudOrders";
            this.Text = "CrudOrders";
            this.Load += new System.EventHandler(this.CrudOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblTitleOrders;
        private System.Windows.Forms.PictureBox pictureBoxPnlProducts;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    }
}