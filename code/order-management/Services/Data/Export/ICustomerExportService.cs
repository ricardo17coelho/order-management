using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Data.Export
{
	public interface ICustomerExportService
	{
		bool Export(string path, List<Customer> customers);
	}
}
