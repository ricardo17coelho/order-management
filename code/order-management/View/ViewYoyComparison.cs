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
        private RepoYoy repoYoy = new RepoYoy();

        public ViewYoyComparison()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<YoyComparison> list = repoYoy.GetYoyComparison();
            DgvYoy.DataSource = list;
        }
    }
}
