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
