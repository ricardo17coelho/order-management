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
        ProductCategoryService categoryService = new ProductCategoryService();
        ViewCategories viewCategories;
        ProductCategory categoryToEdit;

        public FormCategories(ViewCategories viewCategories)
        {
            InitializeComponent();
            this.viewCategories = viewCategories;
            CbParentCategory.DataSource = categoryService.GetAll();
        }

        public FormCategories(ViewCategories viewCategories, ProductCategory categoryToEdit)
        {
            InitializeComponent();
            this.viewCategories = viewCategories;
            this.categoryToEdit = categoryToEdit;
            CbParentCategory.DataSource = categoryService.GetAll();
            LoadCategoryToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            string categoryName = TxtCategoryName.Text;
            ProductCategory parentCategory = categoryService.GetByName(CbParentCategory.Text);

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
                if (CkbRootCategory.Checked)
                {
                    UpdateCategory(new ProductCategory(categoryName));
                }
                else
                {
                    UpdateCategory(new ProductCategory(categoryName, parentCategory));
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
                categoryService.Add(category);
                viewCategories.ReloadData();
                this.Close();
            }
        }

        private void UpdateCategory(ProductCategory category)
        {
            if (IsValid(category))
            {
                categoryService.Update(categoryToEdit, category);
                viewCategories.ReloadData();
                this.Close();
            }
        }

        private Boolean IsUnique(ProductCategory category)
        {
            if (!categoryService.IsUnique(category))
            {
                MessageBox.Show("Category " + category.ProductCategoryName + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(ProductCategory category)
        {
            if (!categoryService.IsValid(category))
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
