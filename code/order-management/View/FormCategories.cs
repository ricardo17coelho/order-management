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
    public partial class FormCategories : Form
    {
        private readonly IProductCategoryService _productCategoryService;
        ViewCategories viewCategories;
        ProductCategory categoryToEdit;

        public FormCategories(IProductCategoryService productCategoryService)
        {
            InitializeComponent();
            _productCategoryService = productCategoryService;
            ReloadData();
        }

        public void ReloadData()
        {
            CbParentCategory.DataSource = _productCategoryService.GetAll();
        }

        public void SetCategoriesView(ViewCategories viewCategories)
        {
            this.viewCategories = viewCategories;
        }

        public void SetProductCategoryToEdit(ProductCategory productCategoryToEdit)
        {
            this.categoryToEdit = productCategoryToEdit;
            LoadCategoryToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            string categoryName = TxtCategoryName.Text;
            ProductCategory parentCategory = _productCategoryService.GetByName(CbParentCategory.Text);

            if (categoryToEdit == null)
            {
                if(CkbRootCategory.Checked)
                {
                    AddNewCategory(new ProductCategory(categoryName));
                } 
                else
                {
                    AddNewCategory(new ProductCategory(categoryName, parentCategory));
                }
            }
            else
            {
                categoryToEdit.ProductCategoryName = categoryName;

                if (CkbRootCategory.Checked)
                {
                    categoryToEdit.Parent = null;
                    UpdateCategory();
                }
                else
                {
                    categoryToEdit.Parent = parentCategory;
                    UpdateCategory();
                }
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCategoryToEditIntoFields()
        {
            TxtCategoryName.Text = categoryToEdit.ProductCategoryName;

            if (categoryToEdit.Parent == null)
            {
                CkbRootCategory.Checked = true;
            }
            else
            {
                CbParentCategory.Text = categoryToEdit.Parent.ToString();
            }

        }

        private void AddNewCategory(ProductCategory category)
        {
            if (IsValid(category) && IsUnique(category))
            {
                _productCategoryService.Add(category);
                viewCategories.ReloadData();
                this.Close();
            }
        }

        private void UpdateCategory()
        {
            if (IsValid(categoryToEdit))
            {
                _productCategoryService.Update(categoryToEdit);
                viewCategories.ReloadData();
                this.Close();
            }
        }

        private Boolean IsUnique(ProductCategory category)
        {
            if (!_productCategoryService.IsUnique(category))
            {
                MessageBox.Show("Category " + category.ProductCategoryName + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(ProductCategory category)
        {
            if (!_productCategoryService.IsValid(category))
            {
                MessageBox.Show("Category Name is required!");
                return false;
            }
            return true;
        }

        private void CkbNewRootCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbRootCategory.Checked)
            {
                CbParentCategory.Enabled = false;
            }
            else
            {
                CbParentCategory.Enabled = true;
            }
        }
    }
}
