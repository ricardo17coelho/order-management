using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace order_management.View
{
    public partial class FormOrders : Form
    {
        ViewOrders viewOrders;

        public FormOrders(ViewOrders viewOrders)
        {
            InitializeComponent();
            this.viewOrders = viewOrders;
            //CbCategory.DataSource = categoryService.GetAll();
        }

    }
}
