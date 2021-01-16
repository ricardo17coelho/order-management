using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class ViewCategories : Form
    {
        ProductCategoryService categoryService = new ProductCategoryService();

        public ViewCategories()
        {
            InitializeComponent();
            ReloadData();
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            new FormCategories(this).ShowDialog();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            new FormCategories(this, (ProductCategory)DgvCategories.CurrentRow.DataBoundItem).ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            categoryService.Delete((ProductCategory)DgvCategories.CurrentRow.DataBoundItem);
            ReloadData();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvCategories.DataSource = categoryService.Search(TxtSearch.Text.ToLower());
        }

        private void DgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvCategories.SelectedRows != null)
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
            DgvCategories.DataSource = categoryService.GetAll();
        }
    }
}
