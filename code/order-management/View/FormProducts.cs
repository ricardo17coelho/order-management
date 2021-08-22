using order_management.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class FormProducts : Form
    {
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        private protected ViewProducts _viewProducts;
        private protected Product _productToEdit;

        public FormProducts(IProductService productService, IProductCategoryService productCategoryService)
        {
            InitializeComponent();
            _productService = productService;
            _productCategoryService = productCategoryService;
            ReloadData();
        }

        private void ReloadData()
        {
            CbCategory.DataSource = _productCategoryService.GetAll();
        }

        public void SetProductsView(ViewProducts viewProducts)
        {
            _viewProducts = viewProducts;
        }

        public void SetProductToEdit(Product productToEdit)
        {
            _productToEdit = productToEdit;
            LoadProductToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            string productName = TxtProductName.Text;
            double price = Convert.ToDouble(NumPrice.Value);
            string unit = TxtUnit.Text;
            DateTime date = DtpDate.Value;
            ProductCategory category = _productCategoryService.GetByName(CbCategory.Text);

            if (_productToEdit == null)
            {
                AddNewProduct(new Product(productName, price, unit, date, category));
            }
            else
            {
                _productToEdit.ProductName = productName;
                _productToEdit.Price = price;
                _productToEdit.Unit = unit;
                _productToEdit.Date = date;
                _productToEdit.ProductCategory = category;

                UpdateCategory();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadProductToEditIntoFields()
        {
            TxtProductName.Text = _productToEdit.ProductName;
            NumPrice.Value = Convert.ToDecimal(_productToEdit.Price);
            TxtUnit.Text = _productToEdit.Unit;
            DtpDate.Value = _productToEdit.Date;
            CbCategory.Text = _productToEdit.ProductCategory.ToString();
        }

        private void AddNewProduct(Product product)
        {
            if (IsValid(product) && IsUnique(product))
            {
                _productService.Add(product);
                _viewProducts.ReloadData();
                this.Close();
            }
        }

        private void UpdateCategory()
        {
            if (IsValid(_productToEdit))
            {
                _productService.Update(_productToEdit);
                _viewProducts.ReloadData();
                this.Close();
            }
        }

        private Boolean IsUnique(Product product)
        {
            if (!_productService.IsUnique(product))
            {
                MessageBox.Show("Product " + product.ProductName + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(Product product)
        {
            if (!_productService.IsValid(product))
            {
                MessageBox.Show("Product Name is required!");
                return false;
            }
            return true;
        }
    }
}
