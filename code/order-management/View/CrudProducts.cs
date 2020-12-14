using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace order_management
{
    public partial class CrudProducts : Form
    {
        private Context context;

        public CrudProducts(Context context)
        {
            this.context= context;
            InitializeComponent();
        }

        private void CrudProducts_Load(object sender, EventArgs e)
        {
            DataGridViewProducts.DataSource = ProductService.GetBoundedList(context);
            DataGridViewProducts.ClearSelection();

            CBProductCategory.DataSource = ProductCategoryService.GetBoundedList(context);

        }

        private void CmdAddNew_Click(object sender, EventArgs e)
        {
            string productName = TxtProductName.Text;
            double price = Convert.ToDouble(NumPrice.Value);
            string unit = TxtUnit.Text;

            var selectedItemFromComboBox = (ProductCategory)CBProductCategory.SelectedItem;

            ProductCategory selectedProductCategory = context.ProductCategories
            .Where(pc => pc.ProductCategoryName == selectedItemFromComboBox.ProductCategoryName)
            .FirstOrDefault<ProductCategory>();

            Product newProduct = new Product(productName, price, unit, selectedProductCategory);


            if (!ProductService.IsValid(context, newProduct))
            {
                MessageBox.Show("Productname is required!");
            }
            else if (!ProductService.IsUnique(context, newProduct))
            {
                MessageBox.Show("Product " + newProduct.ProductName + " already exists!");
            }
            else
            {
                ProductService.Add(context, newProduct);
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
                DataGridViewProducts.ClearSelection();
                foreach (DataGridViewRow row in DataGridViewProducts.Rows)
                {
                   //Cells[1] is ProductName
                   if (row.Cells[1].Value.ToString().ToLower().StartsWith(searchValue.ToLower()))
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            ProductService.SaveChanges(context);
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)DataGridViewProducts.CurrentRow.DataBoundItem;
            ProductService.Remove(context, selectedProduct);
        }
    }
}
