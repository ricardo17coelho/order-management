using order_management.Services;
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
        private readonly IProductService _productService;

        public ViewProducts(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            ReloadData();
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            var formProducts = (FormProducts)Program.ServiceProvider.GetService(typeof(FormProducts));
            formProducts.SetProductsView(this);
            formProducts.ShowDialog();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            var formProducts = (FormProducts)Program.ServiceProvider.GetService(typeof(FormProducts));
            formProducts.SetProductsView(this);
            Product productToEdit = (Product)DgvProducts.CurrentRow.DataBoundItem;
            formProducts.SetProductToEdit(productToEdit);
            formProducts.ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Product productToDelete = (Product)DgvProducts.CurrentRow.DataBoundItem;
            _productService.DeleteById(productToDelete.ProductId);
            ReloadData();
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvProducts.DataSource = _productService.Search(TxtSearch.Text.ToLower());
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
            DgvProducts.DataSource = _productService.GetAll();
            DgvProducts.Columns[0].Visible = false;
            DgvProducts.Columns[6].Visible = false;
        }
    }
}

