using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCascading.Model
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Catgory  { get; set; }
        public string SubCatgory  { get; set; }
        public int? Stock { get; set; }
    }
}
