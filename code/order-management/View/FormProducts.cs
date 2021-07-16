﻿using System;
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
        RepoProduct repoProduct = new RepoProduct();
        RepoProductCategory repoProductCategory = new RepoProductCategory();
        ViewProducts ViewProducts;
        Product productToEdit;

        public FormProducts(ViewProducts viewProducts)
        {
            InitializeComponent();
            this.ViewProducts = viewProducts;
            CbCategory.DataSource = repoProductCategory.GetAll();
        }

        public FormProducts(ViewProducts viewProducts, Product productToEdit)
        {
            InitializeComponent();
            this.ViewProducts = viewProducts;
            this.productToEdit = productToEdit;
            CbCategory.DataSource = repoProductCategory.GetAll();
            LoadProductToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            string productName = TxtProductName.Text;
            double price = Convert.ToDouble(NumPrice.Value);
            string unit = TxtUnit.Text;
            DateTime date = DtpDate.Value;
            ProductCategory category = repoProductCategory.GetByName(CbCategory.Text);

            if (productToEdit == null)
            {
                AddNewProduct(new Product(productName, price, unit, date, category));
            }
            else
            {
                productToEdit.ProductName = productName;
                productToEdit.Price = price;
                productToEdit.Unit = unit;
                productToEdit.Date = date;
                productToEdit.ProductCategory = category;

                UpdateCategory();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadProductToEditIntoFields()
        {
            TxtProductName.Text = productToEdit.ProductName;
            NumPrice.Value = Convert.ToDecimal(productToEdit.Price);
            TxtUnit.Text = productToEdit.Unit;
            DtpDate.Value = productToEdit.Date;
            CbCategory.Text = productToEdit.ProductCategory.ToString();
        }

        private void AddNewProduct(Product product)
        {
            if (IsValid(product) && IsUnique(product))
            {
                repoProduct.Add(product);
                ViewProducts.ReloadData();
                this.Close();
            }
        }

        private void UpdateCategory()
        {
            if (IsValid(productToEdit))
            {
                repoProduct.Update(productToEdit);
                ViewProducts.ReloadData();
                this.Close();
            }
        }

        private Boolean IsUnique(Product product)
        {
            if (!repoProduct.IsUnique(product))
            {
                MessageBox.Show("Product " + product.ProductName + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(Product product)
        {
            if (!repoProduct.IsValid(product))
            {
                MessageBox.Show("Product Name is required!");
                return false;
            }
            return true;
        }
    }
}
