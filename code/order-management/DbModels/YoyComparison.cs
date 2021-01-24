﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace order_management.DbModels
{
    public class YoyComparison
    {
        public string Quarter { get; set; }
        public int CountOrders { get; set; }
        //public int CountProducts { get; set; }
        public int AvgCountProductsPerOrder { get; set; }
        //public int RevenuePerCustomer { get; set; }
        public double TotalRevenue { get; set; }
    }
}
