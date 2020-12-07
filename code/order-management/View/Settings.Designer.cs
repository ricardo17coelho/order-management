
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
            this.CmdGenerateSampleData = new System.Windows.Forms.Button();
            this.btnChangeColors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdGenerateSampleData
            // 
            this.CmdGenerateSampleData.Location = new System.Drawing.Point(388, 111);
            this.CmdGenerateSampleData.Margin = new System.Windows.Forms.Padding(2);
            this.CmdGenerateSampleData.Name = "CmdGenerateSampleData";
            this.CmdGenerateSampleData.Size = new System.Drawing.Size(210, 76);
            this.CmdGenerateSampleData.TabIndex = 2;
            this.CmdGenerateSampleData.Text = "Generate Sample Data";
            this.CmdGenerateSampleData.UseVisualStyleBackColor = true;
            this.CmdGenerateSampleData.Click += new System.EventHandler(this.CmdGenerateSampleData_Click);
            // 
            // btnChangeColors
            // 
            this.btnChangeColors.Location = new System.Drawing.Point(122, 85);
            this.btnChangeColors.Name = "btnChangeColors";
            this.btnChangeColors.Size = new System.Drawing.Size(224, 46);
            this.btnChangeColors.TabIndex = 3;
            this.btnChangeColors.Text = "Change Colors";
            this.btnChangeColors.UseVisualStyleBackColor = true;
            this.btnChangeColors.Click += new System.EventHandler(this.btnChangeColors_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeColors);
            this.Controls.Add(this.CmdGenerateSampleData);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdGenerateSampleData;
        private System.Windows.Forms.Button btnChangeColors;
    }
}