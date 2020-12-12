﻿using Microsoft.EntityFrameworkCore;
using order_management.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace order_management
{
    public partial class DashBoard : Form
    {
        private Context context;

        public DashBoard(Context context)
        {
            InitializeComponent();
            this.context = context;
            UpdateCountLabels();
        }

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            CrudCustomers crudCustomers = new CrudCustomers(context);
            crudCustomers.ShowDialog();
        }

        private void CmdProducts_Click(object sender, EventArgs e)
        {
            CrudProducts crudProducts = new CrudProducts(context);
            crudProducts.ShowDialog();
        }

        private void CmdProductCategory_Click(object sender, EventArgs e)
        {
            CrudProductCategory crudProductCategory = new CrudProductCategory(context);
            crudProductCategory.ShowDialog();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            UpdateCountLabels();
        }

        private void UpdateCountLabels()
        {
            //Would be nicer with a Databinding...
            context.Customers.Load();
            context.ProductCategories.Load();
            context.Products.Load();

            lblCustomersCount.Text = context.Customers.Local.ToBindingList().Count + "";
            lblCategoryCount.Text = context.ProductCategories.Local.ToBindingList().Count + "";
            lblProductsCount.Text = context.Products.Local.ToBindingList().Count + "";
        }

        private void pnlNavCustomers_MouseHover(object sender, EventArgs e)
        {
            pnlNavCustomers.BackColor = Color.White;
            lblNavCustomers.ForeColor = Color.Black;
        }

        private void pnlNavCustomers_Click(object sender, EventArgs e)
        {
            CrudCustomers crudCustomers = new CrudCustomers(context);
            crudCustomers.ShowDialog();
        }

        private void pnlNavCustomers_MouseLeave(object sender, EventArgs e)
        {
            pnlNavCustomers.BackColor = Color.Black;
            lblNavCustomers.ForeColor = Color.White;
        }

        private void pnlNavSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(context);
            settings.ShowDialog();
        }

        private void pnlNavCategories_Click(object sender, EventArgs e)
        {
            CrudProductCategory crudProductCategory = new CrudProductCategory(context);
            crudProductCategory.ShowDialog();
        }

        private void pnlNavProducts_Click(object sender, EventArgs e)
        {
            CrudProducts crudProducts = new CrudProducts(context);
            crudProducts.ShowDialog();
        }

        private void pnlNavProducts_MouseHover(object sender, EventArgs e)
        {
            pnlNavProducts.BackColor = Color.White;
            lblNavProducts.ForeColor = Color.Black;
        }

        private void pnlNavProducts_MouseLeave(object sender, EventArgs e)
        {
            pnlNavProducts.BackColor = Color.Black;
            lblNavProducts.ForeColor = Color.White;
        }

        private void pnlNavCategories_MouseHover(object sender, EventArgs e)
        {
            pnlNavCategories.BackColor = Color.White;
            lblNavCategories.ForeColor = Color.Black;
        }

        private void pnlNavCategories_MouseLeave(object sender, EventArgs e)
        {
            pnlNavCategories.BackColor = Color.Black;
            lblNavCategories.ForeColor = Color.White;
        }

        private void pnlNavSettings_MouseHover(object sender, EventArgs e)
        {
            pnlNavSettings.BackColor = Color.White;
            lblNavSettings.ForeColor = Color.Black;
        }

        private void pnlNavSettings_MouseLeave(object sender, EventArgs e)
        {
            pnlNavSettings.BackColor = Color.Black;
            lblNavSettings.ForeColor = Color.White;
        }
    }
}
