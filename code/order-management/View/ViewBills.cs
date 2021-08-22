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
    public partial class ViewBills : Form
    {
        private readonly IBillService _billService;

        public ViewBills(IBillService billService)
        {
            InitializeComponent();
            CmdDelete.Enabled = false;
            _billService = billService;
            ReloadData();
        }

        private void ReloadData()
        {
            var bills = _billService.GetAll();
            DgvBills.DataSource = bills;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvBills.DataSource = _billService.Search(TxtSearch.Text.ToLower());
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Bill billToDelete = (Bill)DgvBills.CurrentRow.DataBoundItem;
            _billService.DeleteById(billToDelete.BillId);
            ReloadData();
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
