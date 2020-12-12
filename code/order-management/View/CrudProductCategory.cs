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
            DataGridViewProductCategories.DataSource = context.ProductCategories.Local.ToBindingList();
            CBParentCategory.DataSource = context.ProductCategories.Local.ToBindingList();
            var categories = context.ProductCategories.Local.ToBindingList();
            //loop all categories
            foreach (var category in categories) 
            {
                treeViewCategories.Nodes.Add(category.ProductCategoryName);
                //check if category has parentID
                //if (category.ParentId != null)
                //{
                    ////get parentCategory by parentID
                    //var parentCategory = categories.FirstOrDefault(cat => category.ParentId == cat.ProductCategoryId);
                    ////get the parentCategory note into treeView 
                    //var node = treeViewCategories.Nodes.OfType<TreeNode>()
                    //        .FirstOrDefault(node => node.Tag.Equals(parentCategory.ProductCategoryName));
                    //if (node.Index != -1)
                    //{
                    //    //add category to the parentCategory node
                    //    treeViewCategories.Nodes[node.Index].Nodes.Add(category.ProductCategoryName);
                    //}
                    //else {
                    //    //if parentCategory is not in treeView, add it first here and than the category
                    //    treeViewCategories.Nodes.Add(parentCategory.ProductCategoryName);
                    //    var newNode = treeViewCategories.Nodes.OfType<TreeNode>()
                    //           .FirstOrDefault(node => node.Tag.Equals(parentCategory.ProductCategoryName));
                    //    treeViewCategories.Nodes[newNode.Index].Nodes.Add(category.ProductCategoryName);
                    //}
                //} else
                //{
                //    //add new withoud parentId category
                //    treeViewCategories.Nodes.Add(category.ProductCategoryName);
                //}
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
        }
    }
}
