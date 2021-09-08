using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace order_management.Services.Data.Import
{
	public class CustomerImportXml : ICustomerImportService
	{
		public List<Customer> Import(string path)
		{
			var customers = new List<Customer>();
			var serializer = new XmlSerializer(typeof(List<Customer>));

			try
			{
				using var stream = File.OpenRead(path);
				XmlRootAttribute xRoot = new XmlRootAttribute();
				xRoot.ElementName = "Customers";
				xRoot.IsNullable = true;
				List<Customer> xmlCustomers = (List<Customer>)(new XmlSerializer(typeof(List<Customer>), xRoot)).Deserialize(stream);
				//var xmlCustomers = (List<Customer>)(serializer.Deserialize(stream), new XmlRootAttribute("Customers"));
				customers = xmlCustomers;
			}
			catch (Exception e)
			{
				throw new Exception("Import File Exeption", e);
			}

			return customers;
		}
	}
}
