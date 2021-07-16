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
        private RepoBill repoBill = new RepoBill();
        
        public ViewBills()
        {
            InitializeComponent();
            CmdDelete.Enabled = false;
            ReLoadData();
        }

        private void ReLoadData()
        {
            var bills = repoBill.GetAll();
            DgvBills.DataSource = bills;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvBills.DataSource = repoBill.Search(TxtSearch.Text.ToLower());
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            Bill billToDelete = (Bill)DgvBills.CurrentRow.DataBoundItem;
            repoBill.Delete(billToDelete.BillId);
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
