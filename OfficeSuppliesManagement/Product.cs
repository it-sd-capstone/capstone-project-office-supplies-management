using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSuppliesManagement
{
    internal class Product
    {
        public int ID { get; set; }
        public required String Name { get; set; }
        public String? Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }
    }
}
