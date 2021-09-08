using order_management.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Data.Export
{
	public class CustomerExportService
	{
		private readonly ICustomerExportService _customerExportService;
		private protected string _path;
		private protected List<Customer> _customers;
		public CustomerExportService(ICustomerExportService customerExportService)
		{
			_customerExportService = customerExportService;

		}
		public void SetPath(string path)
		{
			_path = path;
		}
		public void SetCustomers(List<Customer> customers)
		{
			_customers = customers;
		}

		public void DoExport()
		{
			_customerExportService.Export(_path, _customers);
		}
	}
}
