using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSuppliesManagement
{
    internal class Supplier
    {
        public int ID { get; set; }
        public required String Name { get; set; }
        public String? PhoneNumber { get; set; }
        public String? Email { get; set; }
        public String? Address { get; set; }
        public required String City { get; set; }
        public String? Region { get; set; }
        public required String Country { get; set; }
        public String? PostalCode { get; set; }
        public String? SalesRep { get; set;}
    }
}
