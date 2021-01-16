using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class ViewProducts : Form
    {
        ProductService productService = new ProductService();

        public ViewProducts()
        {
            InitializeComponent();
            ReloadData();
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            new FormProducts(this).ShowDialog();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            new FormProducts(this, (Product)DgvProducts.CurrentRow.DataBoundItem).ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            productService.Delete((Product)DgvProducts.CurrentRow.DataBoundItem);
            ReloadData();
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvProducts.DataSource = productService.Search(TxtSearch.Text.ToLower());
        }

        private void DgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvProducts.SelectedRows != null)
            {
                CmdEdit.Enabled = true;
                CmdDelete.Enabled = true;
            }
            else
            {
                CmdEdit.Enabled = false;
                CmdDelete.Enabled = false;
            }
        }

        public void ReloadData()
        {
            DgvProducts.DataSource = productService.GetAll();
        }
    }
}

