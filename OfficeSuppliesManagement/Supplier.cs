﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSuppliesManagement
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string City { get; set; }
        public string? Region { get; set; }
        public string Country { get; set; }
        public string? PostalCode { get; set; }
        public string? SalesRepName { get; set; }
    }
}
