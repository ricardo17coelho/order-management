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
        RepoProductCategory repoProductCategory = new RepoProductCategory();
        ViewCategories viewCategories;
        ProductCategory categoryToEdit;

        public FormCategories(ViewCategories viewCategories)
        {
            InitializeComponent();
            this.viewCategories = viewCategories;
            CbParentCategory.DataSource = repoProductCategory.GetAll();
        }

        public FormCategories(ViewCategories viewCategories, ProductCategory categoryToEdit)
        {
            InitializeComponent();
            this.viewCategories = viewCategories;
            this.categoryToEdit = categoryToEdit;
            CbParentCategory.DataSource = repoProductCategory.GetAll();
            LoadCategoryToEditIntoFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            string categoryName = TxtCategoryName.Text;
            ProductCategory parentCategory = repoProductCategory.GetByName(CbParentCategory.Text);

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
                repoProductCategory.Add(category);
                viewCategories.ReloadData();
                this.Close();
            }
        }

        private void UpdateCategory()
        {
            if (IsValid(categoryToEdit))
            {
                repoProductCategory.Update(categoryToEdit);
                viewCategories.ReloadData();
                this.Close();
            }
        }

        private Boolean IsUnique(ProductCategory category)
        {
            if (!repoProductCategory.IsUnique(category))
            {
                MessageBox.Show("Category " + category.ProductCategoryName + " already exists!");
                return false;
            }
            return true;
        }

        private Boolean IsValid(ProductCategory category)
        {
            if (!repoProductCategory.IsValid(category))
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
