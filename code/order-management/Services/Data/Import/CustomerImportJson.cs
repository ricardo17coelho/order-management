using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace order_management.Services.Data.Import
{
	public class CustomerImportJson : ICustomerImportService
	{
		public List<Customer> Import(string path)
		{
			var customers = new List<Customer>();

			try
			{
				using StreamReader file = File.OpenText(path);
				customers = JsonConvert.DeserializeObject<List<Customer>>(file.ReadToEnd());
			}
			catch (Exception e)
			{
				throw new Exception("Import File Exeption", e);
			}

			return customers;
		}
	}
}
