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
            CmdDelete.Enabled = false;
            ReLoadData();
        }

        private void ReLoadData()
        {
            List<Bill> bills = billService.GetAll();
            DgvBills.DataSource = bills;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvBills.DataSource = billService.Search(TxtSearch.Text.ToLower());
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            billService.Delete((Bill)DgvBills.CurrentRow.DataBoundItem);
            ReLoadData();
        }

        private void DgvBills_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBills.SelectedRows != null)
            {
                CmdDelete.Enabled = true;
            }
            else
            {
                CmdDelete.Enabled = false;
            }
        }
    }
}
