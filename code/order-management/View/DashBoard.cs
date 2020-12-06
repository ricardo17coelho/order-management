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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            CrudCustomers crudCustomers =  new CrudCustomers();
            crudCustomers.ShowDialog();
        }
    }
}
