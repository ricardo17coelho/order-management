using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using order_management.DbModels;
using order_management.Services;

namespace order_management.View
{
    public partial class ViewYoyComparison : Form
    {
        private YoyService yoyService = new YoyService();

        public ViewYoyComparison()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<YoyComparison> list = yoyService.GetYoyComparison();
            DgvYoy.DataSource = list;
        }
    }
}
