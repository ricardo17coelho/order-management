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
    public partial class ViewCategoryTreeView : Form
    {
        ProductCategoryService categoryService = new ProductCategoryService();

        public ViewCategoryTreeView()
        {
            InitializeComponent();
        }

        private void ViewCategoryTreeView_Load(object sender, EventArgs e)
        {
            var categories = categoryService.GetAll();
            LoadTreeView(categories);
        }

        private void LoadTreeView(List<ProductCategory> categories)
        {
            TvCategories.Nodes.Clear();
            TreeNode root = null;
            PopulateTree(ref root, categories.ToList());
            TvCategories.Nodes.Add(root);
            TvCategories.ExpandAll();
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


    }
}
