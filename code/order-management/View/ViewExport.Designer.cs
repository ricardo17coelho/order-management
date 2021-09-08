
namespace order_management.View
{
	partial class ViewExport
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
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.CmdOpenPath = new System.Windows.Forms.Button();
            this.CmdExport = new System.Windows.Forms.Button();
            this.GrpBoxData = new System.Windows.Forms.GroupBox();
            this.GrpBoxFormat = new System.Windows.Forms.GroupBox();
            this.RadioCustomers = new System.Windows.Forms.RadioButton();
            this.RadioXml = new System.Windows.Forms.RadioButton();
            this.RadioJson = new System.Windows.Forms.RadioButton();
            this.GrpBoxData.SuspendLayout();
            this.GrpBoxFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(107, 19);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(528, 23);
            this.TxtPath.TabIndex = 0;
            // 
            // CmdOpenPath
            // 
            this.CmdOpenPath.Location = new System.Drawing.Point(12, 19);
            this.CmdOpenPath.Name = "CmdOpenPath";
            this.CmdOpenPath.Size = new System.Drawing.Size(75, 23);
            this.CmdOpenPath.TabIndex = 1;
            this.CmdOpenPath.Text = "Open";
            this.CmdOpenPath.UseVisualStyleBackColor = true;
            this.CmdOpenPath.Click += new System.EventHandler(this.CmdOpenPath_Click);
            // 
            // CmdExport
            // 
            this.CmdExport.Location = new System.Drawing.Point(650, 19);
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(75, 23);
            this.CmdExport.TabIndex = 2;
            this.CmdExport.Text = "Export";
            this.CmdExport.UseVisualStyleBackColor = true;
            this.CmdExport.Click += new System.EventHandler(this.CmdExport_Click);
            // 
            // GrpBoxData
            // 
            this.GrpBoxData.Controls.Add(this.RadioCustomers);
            this.GrpBoxData.Location = new System.Drawing.Point(12, 83);
            this.GrpBoxData.Name = "GrpBoxData";
            this.GrpBoxData.Size = new System.Drawing.Size(339, 123);
            this.GrpBoxData.TabIndex = 3;
            this.GrpBoxData.TabStop = false;
            this.GrpBoxData.Text = "Available Data";
            // 
            // GrpBoxFormat
            // 
            this.GrpBoxFormat.Controls.Add(this.RadioJson);
            this.GrpBoxFormat.Controls.Add(this.RadioXml);
            this.GrpBoxFormat.Location = new System.Drawing.Point(386, 83);
            this.GrpBoxFormat.Name = "GrpBoxFormat";
            this.GrpBoxFormat.Size = new System.Drawing.Size(339, 123);
            this.GrpBoxFormat.TabIndex = 4;
            this.GrpBoxFormat.TabStop = false;
            this.GrpBoxFormat.Text = "Available Formats";
            // 
            // RadioCustomers
            // 
            this.RadioCustomers.AutoSize = true;
            this.RadioCustomers.Location = new System.Drawing.Point(6, 22);
            this.RadioCustomers.Name = "RadioCustomers";
            this.RadioCustomers.Size = new System.Drawing.Size(82, 19);
            this.RadioCustomers.TabIndex = 0;
            this.RadioCustomers.TabStop = true;
            this.RadioCustomers.Text = "Customers";
            this.RadioCustomers.UseVisualStyleBackColor = true;
            // 
            // RadioXml
            // 
            this.RadioXml.AutoSize = true;
            this.RadioXml.Location = new System.Drawing.Point(7, 22);
            this.RadioXml.Name = "RadioXml";
            this.RadioXml.Size = new System.Drawing.Size(49, 19);
            this.RadioXml.TabIndex = 0;
            this.RadioXml.TabStop = true;
            this.RadioXml.Text = "XML";
            this.RadioXml.UseVisualStyleBackColor = true;
            // 
            // RadioJson
            // 
            this.RadioJson.AutoSize = true;
            this.RadioJson.Location = new System.Drawing.Point(7, 48);
            this.RadioJson.Name = "RadioJson";
            this.RadioJson.Size = new System.Drawing.Size(53, 19);
            this.RadioJson.TabIndex = 1;
            this.RadioJson.TabStop = true;
            this.RadioJson.Text = "JSON";
            this.RadioJson.UseVisualStyleBackColor = true;
            // 
            // ExportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrpBoxFormat);
            this.Controls.Add(this.GrpBoxData);
            this.Controls.Add(this.CmdExport);
            this.Controls.Add(this.CmdOpenPath);
            this.Controls.Add(this.TxtPath);
            this.Name = "ExportView";
            this.Text = "ExportView";
            this.GrpBoxData.ResumeLayout(false);
            this.GrpBoxData.PerformLayout();
            this.GrpBoxFormat.ResumeLayout(false);
            this.GrpBoxFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtPath;
		private System.Windows.Forms.Button CmdOpenPath;
		private System.Windows.Forms.Button CmdExport;
		private System.Windows.Forms.GroupBox GrpBoxData;
		private System.Windows.Forms.RadioButton RadioCustomers;
		private System.Windows.Forms.GroupBox GrpBoxFormat;
		private System.Windows.Forms.RadioButton RadioJson;
		private System.Windows.Forms.RadioButton RadioXml;
	}
}