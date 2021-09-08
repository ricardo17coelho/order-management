using order_management.Services;
using order_management.Services.Data.Import;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
	public partial class ViewImport : Form
	{
		private string path;
		private List<Customer> _customers;
		private readonly ICustomerService _customerService;
		private CustomerImportService _customerImportService;

		public ViewImport(ICustomerService customerService)
		{
			InitializeComponent();
			_customerService = customerService;
			_customers = new List<Customer>();
		}

		private void CmdOpenPath_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "Export files (*.xml;*.json)|*.xml;*.json";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					path = openFileDialog.FileName;
					TxtPath.Text = path.ToString();

					string extension = Path.GetExtension(openFileDialog.FileName);

					if (extension == ".xml")
					{
						_customerImportService = new CustomerImportService(new CustomerImportXml());

					}
					else if (extension == ".json")
					{
						_customerImportService = new CustomerImportService(new CustomerImportJson());
					}
					_customerImportService.SetPath(path);
					_customerImportService.Import();

					var customers = _customerImportService.GetCustomers();

					foreach (var customer in customers)
					{
						customer.City = null;
						_customers.Add(customer);
					}

					LoadTable(_customers);
				}
			}

		}

		private void CmdImport_Click(object sender, EventArgs e)
		{
			if (_customers != null)
			{
				foreach (var customer in _customers)
				{
					try
					{
						var _customer = _customerService.GetById(customer.CustomerId);
						_customerService.Update(customer);

					} catch
					{
						_customerService.Add(customer);
					}
				}

				MessageBox.Show("Import war sucessfull",
					"Info",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
			}
		}

		private void LoadTable(List<Customer> customers)
		{
			DgvCustomers.DataSource = customers;

			DgvCustomers.Columns[0].Visible = false;
			DgvCustomers.Columns[2].Visible = false;
			DgvCustomers.Columns[3].Visible = false;
			DgvCustomers.Columns[4].Visible = false;
			DgvCustomers.Columns[8].Visible = false;
			DgvCustomers.Columns[9].Visible = false;
			DgvCustomers.Columns[10].Visible = false;
			DgvCustomers.Columns[11].Visible = false;
			DgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DgvCustomers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			DgvCustomers.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			DgvCustomers.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			DgvCustomers.Columns[1].HeaderText = "Kunden-Nr";
			DgvCustomers.Columns[5].HeaderText = "Name";
			DgvCustomers.Columns[6].HeaderText = "Strasse";
			DgvCustomers.Columns[7].HeaderText = "Nr";
		}
	}
}
