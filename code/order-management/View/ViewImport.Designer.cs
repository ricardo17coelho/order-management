
namespace order_management.View
{
	partial class ViewImport
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
            this.CmdOpenPath = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.CmdImport = new System.Windows.Forms.Button();
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOpenPath
            // 
            this.CmdOpenPath.Location = new System.Drawing.Point(22, 23);
            this.CmdOpenPath.Name = "CmdOpenPath";
            this.CmdOpenPath.Size = new System.Drawing.Size(80, 24);
            this.CmdOpenPath.TabIndex = 0;
            this.CmdOpenPath.Text = "Open";
            this.CmdOpenPath.UseVisualStyleBackColor = true;
            this.CmdOpenPath.Click += new System.EventHandler(this.CmdOpenPath_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(136, 23);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(542, 23);
            this.TxtPath.TabIndex = 1;
            // 
            // CmdImport
            // 
            this.CmdImport.Location = new System.Drawing.Point(684, 21);
            this.CmdImport.Name = "CmdImport";
            this.CmdImport.Size = new System.Drawing.Size(80, 24);
            this.CmdImport.TabIndex = 2;
            this.CmdImport.Text = "Import";
            this.CmdImport.UseVisualStyleBackColor = true;
            this.CmdImport.Click += new System.EventHandler(this.CmdImport_Click);
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.AllowUserToAddRows = false;
            this.DgvCustomers.AllowUserToDeleteRows = false;
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Location = new System.Drawing.Point(22, 84);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.ReadOnly = true;
            this.DgvCustomers.RowTemplate.Height = 25;
            this.DgvCustomers.Size = new System.Drawing.Size(742, 307);
            this.DgvCustomers.TabIndex = 3;
            // 
            // ViewImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvCustomers);
            this.Controls.Add(this.CmdImport);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.CmdOpenPath);
            this.Name = "ViewImport";
            this.Text = "ImportView";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CmdOpenPath;
		private System.Windows.Forms.TextBox TxtPath;
		private System.Windows.Forms.Button CmdImport;
		private System.Windows.Forms.DataGridView DgvCustomers;
	}
}