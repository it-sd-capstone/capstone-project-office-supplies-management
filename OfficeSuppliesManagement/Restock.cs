using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSuppliesManagement
{
    internal class Restock
    {
        public int RestockID { get; set; }
        public int ItemId { get; set; }
        public int SupplierId { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpRestock { get; set; }
    }
}
