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
        RepoProductCategory repoProductCategory = new RepoProductCategory();

        public ViewCategoryTreeView()
        {
            InitializeComponent();
        }

        private void ViewCategoryTreeView_Load(object sender, EventArgs e)
        {
            var categories = repoProductCategory.GetCteDataForTreeView();
            BuildTreeView(categories);
        }

        private void BuildTreeView(List<ProductCategory> categories)
        {
            TvCategories.Nodes.Clear();
            PopulateTreeView(categories, null);
            TvCategories.ExpandAll();
        }

        //Build TreeView recursively
        private void PopulateTreeView(List<ProductCategory> items, TreeNode node)
        {
            var parentID = node != null
                ? (int)node.Tag
                : 0;

            var nodesCollection = node != null
                ? node.Nodes
                : TvCategories.Nodes;

            foreach (var item in items.Where(i => i.ParentId == parentID))
            {
                var newNode = nodesCollection.Add(item.ProductCategoryName, item.ProductCategoryName);
                newNode.Tag = item.ProductCategoryId;

                PopulateTreeView(items, newNode);
            }
        }
    }
}
