using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            var viewCustomers = (ViewCustomers)Program.ServiceProvider.GetService((typeof(ViewCustomers)));
            viewCustomers.ShowDialog();
        }

        private void CmdCategories_Click(object sender, EventArgs e)
        {
            var viewCategories = (ViewCategories)Program.ServiceProvider.GetService((typeof(ViewCategories)));
            viewCategories.ShowDialog();
        }

        private void CmdProducts_Click(object sender, EventArgs e)
        {
            var viewProducts = (ViewProducts)Program.ServiceProvider.GetService((typeof(ViewProducts)));
            viewProducts.ShowDialog();
        }

        private void CmdOrders_Click(object sender, EventArgs e)
        {
            var viewOrders = (ViewOrders)Program.ServiceProvider.GetService((typeof(ViewOrders)));
            viewOrders.ShowDialog();
        }

        private void CmdCategoryTreeView_Click(object sender, EventArgs e)
        {
            var viewCategoryTreeView = (ViewCategoryTreeView)Program.ServiceProvider.GetService((typeof(ViewCategoryTreeView)));
            viewCategoryTreeView.ShowDialog();
        }

        private void CmdYoyComparison_Click(object sender, EventArgs e)
        {
            var viewYoyComparison = (ViewYoyComparison)Program.ServiceProvider.GetService((typeof(ViewYoyComparison)));
            viewYoyComparison.ShowDialog();
        }

        private void CmdBills_Click(object sender, EventArgs e)
        {
            var viewBills = (ViewBills)Program.ServiceProvider.GetService((typeof(ViewBills)));
            viewBills.ShowDialog();
        }

		private void CmdExport_Click(object sender, EventArgs e)
		{
			var viewExport = (ViewExport)Program.ServiceProvider.GetService((typeof(ViewExport)));
			viewExport.ShowDialog();
		}

		private void CmdImport_Click(object sender, EventArgs e)
		{
			var viewImport = (ViewImport)Program.ServiceProvider.GetService((typeof(ViewImport)));
			viewImport.ShowDialog();
		}
	}
}
