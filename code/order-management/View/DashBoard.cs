using order_management.View;
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
        private RepositoryManager repositoryManager;


        public DashBoard(RepositoryManager repositoryManager)
        {
            InitializeComponent();
            this.repositoryManager = repositoryManager;
        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            CrudCustomers crudCustomers = new CrudCustomers(repositoryManager);
            crudCustomers.ShowDialog();
        }

        private void CmdProducts_Click(object sender, EventArgs e)
        {
            CrudProducts crudProducts = new CrudProducts(repositoryManager);
            crudProducts.ShowDialog();
        }

        private void linkLabelClients_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrudCustomers crudCustomers = new CrudCustomers(repositoryManager);
            crudCustomers.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrudProducts crudProducts = new CrudProducts(repositoryManager);
            crudProducts.ShowDialog();
        }

        private void linkLblSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings settings = new Settings(repositoryManager);
            settings.ShowDialog();
        }
    }
}
