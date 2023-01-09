namespace ListOfSuppliers.Model
{
    public class SupplierItem
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int? NumberOfContainer { get; set; }
        public string QualityOfProduct { get; set; }
        public double Amount { get; set; }

    }
}
