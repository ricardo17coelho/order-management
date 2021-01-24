using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using order_management.DbModels;

namespace order_management.View
{
    public partial class ViewBills : Form
    {
        private BillService billService = new BillService();
        
        public ViewBills()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<Bill> customers = billService.GetBills();
            DgvBills.DataSource = customers;
        }
    }
}
