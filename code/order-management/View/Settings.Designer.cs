
namespace order_management.View
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.CmdClearData = new System.Windows.Forms.Button();
            this.CmdGenerateSampleData = new System.Windows.Forms.Button();
            this.lblTitleSettings = new System.Windows.Forms.Label();
            this.pictureBoxPnlProducts = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdClearData
            // 
            this.CmdClearData.Location = new System.Drawing.Point(778, 204);
            this.CmdClearData.Margin = new System.Windows.Forms.Padding(2);
            this.CmdClearData.Name = "CmdClearData";
            this.CmdClearData.Size = new System.Drawing.Size(418, 125);
            this.CmdClearData.TabIndex = 6;
            this.CmdClearData.Text = "Clear all Data";
            this.CmdClearData.UseVisualStyleBackColor = true;
            this.CmdClearData.Click += new System.EventHandler(this.CmdClearData_Click);
            // 
            // CmdGenerateSampleData
            // 
            this.CmdGenerateSampleData.Location = new System.Drawing.Point(778, 387);
            this.CmdGenerateSampleData.Margin = new System.Windows.Forms.Padding(2);
            this.CmdGenerateSampleData.Name = "CmdGenerateSampleData";
            this.CmdGenerateSampleData.Size = new System.Drawing.Size(418, 124);
            this.CmdGenerateSampleData.TabIndex = 7;
            this.CmdGenerateSampleData.Text = "Generate Sample Data";
            this.CmdGenerateSampleData.UseVisualStyleBackColor = true;
            this.CmdGenerateSampleData.Click += new System.EventHandler(this.CmdGenerateSampleData_Click);
            // 
            // lblTitleSettings
            // 
            this.lblTitleSettings.AutoEllipsis = true;
            this.lblTitleSettings.AutoSize = true;
            this.lblTitleSettings.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleSettings.ForeColor = System.Drawing.Color.White;
            this.lblTitleSettings.Location = new System.Drawing.Point(140, -2);
            this.lblTitleSettings.Name = "lblTitleSettings";
            this.lblTitleSettings.Size = new System.Drawing.Size(322, 93);
            this.lblTitleSettings.TabIndex = 3;
            this.lblTitleSettings.Text = "Settings";
            // 
            // pictureBoxPnlProducts
            // 
            this.pictureBoxPnlProducts.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPnlProducts.Image")));
            this.pictureBoxPnlProducts.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPnlProducts.Name = "pictureBoxPnlProducts";
            this.pictureBoxPnlProducts.Size = new System.Drawing.Size(117, 96);
            this.pictureBoxPnlProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPnlProducts.TabIndex = 4;
            this.pictureBoxPnlProducts.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblTitleSettings);
            this.pnlTop.Controls.Add(this.pictureBoxPnlProducts);
            this.pnlTop.Location = new System.Drawing.Point(12, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1463, 106);
            this.pnlTop.TabIndex = 10;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1487, 996);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.CmdGenerateSampleData);
            this.Controls.Add(this.CmdClearData);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPnlProducts)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdClearData;
        private System.Windows.Forms.Button CmdGenerateSampleData;
        private System.Windows.Forms.Label lblTitleSettings;
        private System.Windows.Forms.PictureBox pictureBoxPnlProducts;
        private System.Windows.Forms.Panel pnlTop;
    }
}