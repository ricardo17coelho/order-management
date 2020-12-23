using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class YOYComparison : Form
    {
        Context context;
        public YOYComparison(Context context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void YOYComparison_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("YOY DataSet");
            DataTable dt = new DataTable("YOY DataTable");


            DataColumn category = new DataColumn("Category");
            dt.Columns.Add(category);
            
            DataColumn yoy = new DataColumn("YOY");
            dt.Columns.Add(yoy);
            
            DataColumn q42020 = new DataColumn("Q4 2020");
            dt.Columns.Add(q42020);
            
            DataColumn q32020 = new DataColumn("Q3 2020");
            dt.Columns.Add(q32020);
            
            DataColumn q22020 = new DataColumn("Q2 2020");
            dt.Columns.Add(q22020);
            
            DataColumn q12020 = new DataColumn("Q1 2020");
            dt.Columns.Add(q12020);


            ds.Tables.Add(dt);


            DataRow countOrders = ds.Tables[0].NewRow();
            countOrders["Category"] = "Count Orders";
            countOrders["YOY"] = "TODO";
            countOrders["Q4 2020"] = "TODO";
            countOrders["Q3 2020"] = "TODO";
            countOrders["Q2 2020"] = "TODO";
            countOrders["Q1 2020"] = "TODO";
            ds.Tables[0].Rows.Add(countOrders);

            DataRow countProducts = ds.Tables[0].NewRow();
            countProducts["Category"] = "Count Products";
            countProducts["YOY"] = "TODO";
            countProducts["Q4 2020"] = "TODO";
            countProducts["Q3 2020"] = "TODO";
            countProducts["Q2 2020"] = "TODO";
            countProducts["Q1 2020"] = "TODO";
            ds.Tables[0].Rows.Add(countProducts);

            DataRow averageProductsPerCustomer = ds.Tables[0].NewRow();
            averageProductsPerCustomer["Category"] = "Average Products per Customer";
            averageProductsPerCustomer["YOY"] = "TODO";
            averageProductsPerCustomer["Q4 2020"] = "TODO";
            averageProductsPerCustomer["Q3 2020"] = "TODO";
            averageProductsPerCustomer["Q2 2020"] = "TODO";
            averageProductsPerCustomer["Q1 2020"] = "TODO";
            ds.Tables[0].Rows.Add(averageProductsPerCustomer);

            DataRow averageRevenuePerCustomer = ds.Tables[0].NewRow();
            averageRevenuePerCustomer["Category"] = "Average Revenue per Customer";
            averageRevenuePerCustomer["YOY"] = "TODO";
            averageRevenuePerCustomer["Q4 2020"] = "TODO";
            averageRevenuePerCustomer["Q3 2020"] = "TODO";
            averageRevenuePerCustomer["Q2 2020"] = "TODO";
            averageRevenuePerCustomer["Q1 2020"] = "TODO";
            ds.Tables[0].Rows.Add(averageRevenuePerCustomer);

            DataRow totalRevenue = ds.Tables[0].NewRow();
            totalRevenue["Category"] = "Total Revenue";
            totalRevenue["YOY"] = "TODO";
            totalRevenue["Q4 2020"] = "TODO";
            totalRevenue["Q3 2020"] = "TODO";
            totalRevenue["Q2 2020"] = "TODO";
            totalRevenue["Q1 2020"] = "TODO";
            ds.Tables[0].Rows.Add(totalRevenue);


            ds.AcceptChanges();

            DataGridViewYOY.DataSource = dt;
        }
    }
}
