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

        public CrudProductCategory(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void CrudProductCategory_Load(object sender, EventArgs e)
        {
            var categories = ProductCategoryService.GetBoundedList(context);
            DataGridViewProductCategories.DataSource = categories;
            CBParentCategory.DataSource = categories;
            LoadTreeView(categories);
        }

        private void LoadTreeView(BindingList<ProductCategory> categories)
        {
            treeViewCategories.Nodes.Clear();
            TreeNode root = null;
            PopulateTree(ref root, categories.ToList());
            treeViewCategories.Nodes.Add(root);
            treeViewCategories.ExpandAll();
        }

        public void PopulateTree(ref TreeNode root, List<ProductCategory> categoriesList)
        {
            if (root == null)
            {
                root = new TreeNode();
                root.Text = "Categories";
                root.Tag = null;
                // get all departments in the list with parent is null
                var sortedCategories = categoriesList.Where(t => t.ParentId == null);
                foreach (var category in sortedCategories)
                {
                    var child = new TreeNode()
                    {
                        Text = category.ProductCategoryName,
                        Tag = category.ProductCategoryId,
                    };
                    PopulateTree(ref child, categoriesList);
                    root.Nodes.Add(child);
                }
            }
            else
            {
                var id = (int)root.Tag;
                var sortedCategories = categoriesList.Where(t => t.ParentId == id);
                foreach (var category in sortedCategories)
                {
                    var child = new TreeNode()
                    {
                        Text = category.ProductCategoryName,
                        Tag = category.ProductCategoryId,
                    };
                    PopulateTree(ref child, categoriesList);
                    root.Nodes.Add(child);
                }
            }
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
                LoadTreeView(ProductCategoryService.GetBoundedList(context));
            }
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
    }
}
