
using System;

namespace Business.ModelView
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string ProductName { get; set; }
        public int? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public double? Discount { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string FilePath { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? SupplierId { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ServerCreate { get; set; }
        public string ServerUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
