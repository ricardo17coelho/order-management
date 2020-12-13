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
            context.ProductCategories.Load();
            var categories = context.ProductCategories.Local.ToBindingList();
            DataGridViewProductCategories.DataSource = categories;
            CBParentCategory.DataSource = categories;
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
            string productCategoryName = TxtProductCategoryName.Text;
            var selectedItemFromComboBox = (ProductCategory)CBParentCategory.SelectedItem;


            ProductCategory parentCategory = context.ProductCategories
            .Where(pc => pc.ProductCategoryName == selectedItemFromComboBox.ProductCategoryName)
            .FirstOrDefault<ProductCategory>();

            ProductCategory newProductCategory = new ProductCategory(productCategoryName, parentCategory);

            context.ProductCategories.Add(newProductCategory);
            context.SaveChanges();
            //check if newProductCategory has not parentId
            if (newProductCategory.ParentId == null)
            {
                //add newProductCategory to treeview
                treeViewCategories.Nodes.Add(productCategoryName);
            }
            else
            {
                //get parentNode by parentId
                var insertedNode = treeViewCategories.Nodes.Find(selectedItemFromComboBox.ProductCategoryName, true);
                Console.WriteLine(insertedNode);
                //create a treeNode child
                var child = new TreeNode()
                {
                    Text = newProductCategory.ProductCategoryName,
                    Tag = newProductCategory.ProductCategoryId,
                };
                //insert the childNote into the treeView
                //insertedNode[0].Nodes.Add(child);
            }
        }
    }
}
