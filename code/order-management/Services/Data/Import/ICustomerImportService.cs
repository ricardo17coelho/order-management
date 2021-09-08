using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services.Data.Import
{
	public interface ICustomerImportService
	{
		List<Customer> Import(string path);
	}
}
