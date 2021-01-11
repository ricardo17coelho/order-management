using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class CrudProductCategory : Form
    {

        private Context context;
        private DashBoard dashBoard;

        public CrudProductCategory(Context context, DashBoard dashBoard)
        {
            this.context = context;
            this.dashBoard = dashBoard;
            InitializeComponent();
        }

        private void CrudProductCategory_Load(object sender, EventArgs e)
        {
            var categories = ProductCategoryService.GetBoundedList(context);
            DataGridViewProductCategories.DataSource = categories;
            DataGridViewProductCategories.ClearSelection();
            CBParentCategory.DataSource = categories;
        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            ProductCategory parentCategory;
            ProductCategory newProductCategory;

            if (CHBRootCategory.Checked)
            {
                newProductCategory = new ProductCategory(TxtProductCategoryName.Text);
            }
            else
            {
                parentCategory = ProductCategoryService.GetEntityByName(context, CBParentCategory.Text);
                newProductCategory = new ProductCategory(TxtProductCategoryName.Text, parentCategory);
            }


            if (!ProductCategoryService.IsValid(context, newProductCategory))
            {
                MessageBox.Show("Category name is required!");
            }
            else if (!ProductCategoryService.IsUnique(context, newProductCategory))
            {
                MessageBox.Show("Product Category" + newProductCategory.ProductCategoryName + " already exists!");
            }
            else
            {
                ProductCategoryService.Add(context, newProductCategory);
            }
            dashBoard.UpdateCountLabels();
        }

        private void CHBRootCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (CHBRootCategory.Checked)
            {
                CBParentCategory.Visible = false;
            }
            else
            {
                CBParentCategory.Visible = true;
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            string searchValue = TxtSearch.Text;
            if (searchValue == "")
            {
                MessageBox.Show("Enter a Value!");
            }
            else
            {
                DataGridViewProductCategories.ClearSelection();
                foreach (DataGridViewRow row in DataGridViewProductCategories.Rows)
                {
                    //Cells[1] is ProductCategoryName
                    if (row.Cells[1].Value.ToString().ToLower().StartsWith(searchValue.ToLower()))
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            ProductCategoryService.SaveChanges(context);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            ProductCategory selectedProductCategory = (ProductCategory)DataGridViewProductCategories.CurrentRow.DataBoundItem;
            ProductCategoryService.Remove(context, selectedProductCategory);
            dashBoard.UpdateCountLabels();
        }
    }
}
