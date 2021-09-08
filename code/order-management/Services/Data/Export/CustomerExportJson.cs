using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace order_management.Data.Export
{
	public class CustomerExportJson : ICustomerExportService
	{
		public bool Export(string path, List<Customer> customers)
		{

			var options = new JsonSerializerOptions()
			{
				WriteIndented = true,
			};
			var serializedCustomerJson = JsonSerializer.Serialize(customers, options);
			serializedCustomerJson = serializedCustomerJson.Replace("\r\n", "\n");

			try
			{
				using StreamWriter file = File.CreateText(path);
				file.Write(serializedCustomerJson);
			}
			catch (Exception e)
			{
				throw new Exception("Export File Exeption", e);
			}

			return true;
		}
	}
}
