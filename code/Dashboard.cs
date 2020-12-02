using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order_management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void iconArticles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Articles click");
        }

        private void iconOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orders click");
        }

        private void iconClients_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clients click");
        }
    }
}
