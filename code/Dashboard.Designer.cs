
namespace order_management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxClients = new System.Windows.Forms.GroupBox();
            this.iconClients = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.groupBoxArticles = new System.Windows.Forms.GroupBox();
            this.iconArticles = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductsView = new System.Windows.Forms.Label();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.iconOrders = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrdersView = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClients)).BeginInit();
            this.groupBoxArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconArticles)).BeginInit();
            this.groupBoxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxClients);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxArticles);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxOrders);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1182, 182);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxClients
            // 
            this.groupBoxClients.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBoxClients.Controls.Add(this.iconClients);
            this.groupBoxClients.Controls.Add(this.label1);
            this.groupBoxClients.Controls.Add(this.lblClient);
            this.groupBoxClients.Location = new System.Drawing.Point(3, 3);
            this.groupBoxClients.Name = "groupBoxClients";
            this.groupBoxClients.Size = new System.Drawing.Size(376, 170);
            this.groupBoxClients.TabIndex = 0;
            this.groupBoxClients.TabStop = false;
            this.groupBoxClients.Text = "Kunden";
            // 
            // iconClients
            // 
            this.iconClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClients.Image = ((System.Drawing.Image)(resources.GetObject("iconClients.Image")));
            this.iconClients.Location = new System.Drawing.Point(22, 36);
            this.iconClients.Name = "iconClients";
            this.iconClients.Size = new System.Drawing.Size(102, 112);
            this.iconClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClients.TabIndex = 2;
            this.iconClients.TabStop = false;
            this.iconClients.Click += new System.EventHandler(this.iconClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "100";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(130, 36);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(213, 61);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Kunden";
            // 
            // groupBoxArticles
            // 
            this.groupBoxArticles.BackColor = System.Drawing.SystemColors.GrayText;
            this.groupBoxArticles.Controls.Add(this.iconArticles);
            this.groupBoxArticles.Controls.Add(this.label2);
            this.groupBoxArticles.Controls.Add(this.lblProductsView);
            this.groupBoxArticles.Location = new System.Drawing.Point(385, 3);
            this.groupBoxArticles.Name = "groupBoxArticles";
            this.groupBoxArticles.Size = new System.Drawing.Size(376, 170);
            this.groupBoxArticles.TabIndex = 1;
            this.groupBoxArticles.TabStop = false;
            this.groupBoxArticles.Text = "Artikel";
            // 
            // iconArticles
            // 
            this.iconArticles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconArticles.Image = ((System.Drawing.Image)(resources.GetObject("iconArticles.Image")));
            this.iconArticles.Location = new System.Drawing.Point(28, 36);
            this.iconArticles.Name = "iconArticles";
            this.iconArticles.Size = new System.Drawing.Size(102, 112);
            this.iconArticles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconArticles.TabIndex = 3;
            this.iconArticles.TabStop = false;
            this.iconArticles.Click += new System.EventHandler(this.iconArticles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 61);
            this.label2.TabIndex = 5;
            this.label2.Text = "100";
            // 
            // lblProductsView
            // 
            this.lblProductsView.AutoSize = true;
            this.lblProductsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsView.ForeColor = System.Drawing.Color.White;
            this.lblProductsView.Location = new System.Drawing.Point(136, 36);
            this.lblProductsView.Name = "lblProductsView";
            this.lblProductsView.Size = new System.Drawing.Size(180, 61);
            this.lblProductsView.TabIndex = 3;
            this.lblProductsView.Text = "Artikel";
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBoxOrders.Controls.Add(this.iconOrders);
            this.groupBoxOrders.Controls.Add(this.label4);
            this.groupBoxOrders.Controls.Add(this.lblOrdersView);
            this.groupBoxOrders.Location = new System.Drawing.Point(767, 3);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(405, 170);
            this.groupBoxOrders.TabIndex = 2;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Aufträge";
            // 
            // iconOrders
            // 
            this.iconOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconOrders.Image = ((System.Drawing.Image)(resources.GetObject("iconOrders.Image")));
            this.iconOrders.Location = new System.Drawing.Point(31, 36);
            this.iconOrders.Name = "iconOrders";
            this.iconOrders.Size = new System.Drawing.Size(102, 112);
            this.iconOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconOrders.TabIndex = 6;
            this.iconOrders.TabStop = false;
            this.iconOrders.Click += new System.EventHandler(this.iconOrders_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(231, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 61);
            this.label4.TabIndex = 8;
            this.label4.Text = "100";
            // 
            // lblOrdersView
            // 
            this.lblOrdersView.AutoSize = true;
            this.lblOrdersView.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersView.ForeColor = System.Drawing.Color.White;
            this.lblOrdersView.Location = new System.Drawing.Point(154, 36);
            this.lblOrdersView.Name = "lblOrdersView";
            this.lblOrdersView.Size = new System.Drawing.Size(234, 61);
            this.lblOrdersView.TabIndex = 6;
            this.lblOrdersView.Text = "Aufträge";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 736);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxClients.ResumeLayout(false);
            this.groupBoxClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClients)).EndInit();
            this.groupBoxArticles.ResumeLayout(false);
            this.groupBoxArticles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconArticles)).EndInit();
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox groupBoxArticles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductsView;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrdersView;
        private System.Windows.Forms.PictureBox iconClients;
        private System.Windows.Forms.PictureBox iconArticles;
        private System.Windows.Forms.PictureBox iconOrders;
    }
}

