using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management
{
    public partial class CrudProducts : Form
    {

        private RepositoryManager repositoryManager;
        public CrudProducts(RepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
            InitializeComponent();
        }

        private void CrudProducts_Load(object sender, EventArgs e)
        {
            DataGridViewProducts.DataSource = repositoryManager.ProductRepository.GetBoundedList();

        }
    }
}
