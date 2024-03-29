﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.HR;
using Clinic.Model.CRM;

namespace Clinic.Model.ERP
{
    /// <summary>
    /// Medical, chemotherapy protocols ...
    /// </summary>
    public class Order
    {
        public DateTime Date { set; get; }
        public Partner Customer { set; get; }
        public Partner HandleBy { set; get; }
        public List<LineItem> LineItems { set; get; }
        public Discount Discount { set; get; }
        public Payment Payment { set; get; }
        public decimal TotalPrice { set; get; }
        public OrderStatus Status { set; get; }
    }
}
