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
            new ViewCustomers().ShowDialog();
        }

        private void CmdCategories_Click(object sender, EventArgs e)
        {
            new ViewCategories().ShowDialog();
        }

        private void CmdProducts_Click(object sender, EventArgs e)
        {
            new ViewProducts().ShowDialog();

        }

        private void CmdCategoryTreeView_Click(object sender, EventArgs e)
        {
            new ViewCategoryTreeView().ShowDialog();
        }
    }
}
