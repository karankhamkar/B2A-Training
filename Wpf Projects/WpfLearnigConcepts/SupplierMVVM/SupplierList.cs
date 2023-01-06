using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierMVVM
{
    public class SupplierList
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int TransactionId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ProductName { get; set; }
        public double Amount { get; set; }
    }
}
