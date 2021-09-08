using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace order_management.Data.Export
{
	public class CustomerExportXml : ICustomerExportService
	{
		public bool Export(string path, List<Customer> customers)
		{
			XmlSerializer writer = new XmlSerializer(typeof(List<Customer>), new XmlRootAttribute("Customers"));

			try
			{
				using var stream = File.OpenWrite(path);
				writer.Serialize(stream, customers);
			}
			catch (Exception e)
			{
				throw new Exception("Export File Exeption", e);
			}

			return true;
		}
	}
}
