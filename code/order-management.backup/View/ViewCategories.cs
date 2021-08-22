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
        RepoProductCategory repoProductCategory = new RepoProductCategory();

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
            ProductCategory category = (ProductCategory)DgvCategories.CurrentRow.DataBoundItem;
            var filteredList = repoProductCategory.GetChildrenByParentId(category.ProductCategoryId);
            if (filteredList.Count > 0)
            {
                string message = "You need to delete all the children first:";
                string title = "Category has children";
                var newLine = "\r\n";
                foreach (var item in filteredList)
                {
                    message += newLine;
                    message += "- " + item.ProductCategoryName;
                }
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show(message, title, buttons);

            } else
            {
                string message = "Do you want to delete category?";
                string title = "Delete Category";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    repoProductCategory.Delete(category.ProductCategoryId);
                    ReloadData();
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvCategories.DataSource = repoProductCategory.Search(TxtSearch.Text.ToLower());
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
            DgvCategories.DataSource = repoProductCategory.GetAll();
            DgvCategories.Columns[0].Visible = false;
            DgvCategories.Columns[3].Visible = false;
        }
    }
}
