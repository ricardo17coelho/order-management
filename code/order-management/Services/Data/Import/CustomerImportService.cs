using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services.Data.Import
{
	public class CustomerImportService
	{
		private readonly ICustomerImportService _customerImportService;
		private List<Customer> _customers;
		private string _path;
		public CustomerImportService(ICustomerImportService customerImportService)
		{
			_customerImportService = customerImportService;
		}

		public List<Customer> Import()
		{
			_customers = _customerImportService.Import(_path);
			return _customers;
		}

		public void SetPath(string path)
		{
			_path = path;
		}
		public List<Customer> GetCustomers()
		{
			return _customers;
		}
	}
}
