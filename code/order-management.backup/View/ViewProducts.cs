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
        RepoProduct repoProduct = new RepoProduct();

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
            Product productToDelete = (Product)DgvProducts.CurrentRow.DataBoundItem;
            repoProduct.Delete(productToDelete.ProductId);
            ReloadData();
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvProducts.DataSource = repoProduct.Search(TxtSearch.Text.ToLower());
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
            DgvProducts.DataSource = repoProduct.GetAll();
            DgvProducts.Columns[0].Visible = false;
            DgvProducts.Columns[6].Visible = false;
        }
    }
}

