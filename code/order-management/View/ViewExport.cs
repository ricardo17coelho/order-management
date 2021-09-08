using order_management.Data.Export;
using order_management.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
	public partial class ViewExport : Form
	{
		private readonly ICustomerService _customerService;
		private CustomerExportService _customerExportService;
		private string _path;
		//public ViewExport(ICustomerService customerService, CustomerExportService customerExportService)
		public ViewExport(ICustomerService customerService)
		{
			InitializeComponent();
			_customerService = customerService;
			//_customerExportService = customerExportService;
		}

		private void CmdOpenPath_Click(object sender, EventArgs e)
		{
			using SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = "c:\\";
			saveFileDialog.Filter = "Export files (*.xml;*.json)|*.xml;*.json";
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.RestoreDirectory = true;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				_path = saveFileDialog.FileName;
				TxtPath.Text = _path;
			}
		}

		private void CmdExport_Click(object sender, EventArgs e)
		{
			if (_path != string.Empty)
			{
				var customers = _customerService.GetAll();
				if (RadioXml.Checked == true)
				{
					_customerExportService = new CustomerExportService(new CustomerExportXml());

				}
				else if (RadioJson.Checked == true)
				{
					_customerExportService = new CustomerExportService(new CustomerExportJson());
				}
				_customerExportService.SetCustomers(customers);
				_customerExportService.SetPath(_path);
				_customerExportService.DoExport();

				MessageBox.Show("Export was successfull",
					"INFO",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}
	}
}
