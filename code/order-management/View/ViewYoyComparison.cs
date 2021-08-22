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
    public partial class ViewYoyComparison : Form
    {
        private readonly IYoyComparisonService _yoyComparisonService;

        public ViewYoyComparison(IYoyComparisonService yoyComparisonService)
        {
            InitializeComponent();
            _yoyComparisonService = yoyComparisonService;
            LoadData();
        }

        private void LoadData()
        {
            List<YoyComparison> list = _yoyComparisonService.GetYoyComparison();
            DgvYoy.DataSource = list;
        }
    }
}
