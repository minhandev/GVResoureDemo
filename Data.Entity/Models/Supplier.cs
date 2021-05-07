using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entity.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string SupplierName { get; set; }
        public string ContractName { get; set; }
        public string ContractTitle { get; set; }
        public string ContractCode { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string FilePath { get; set; }
        public Guid? PositionId { get; set; }
        public Guid? ProvinceId { get; set; }
        public Guid? CountryId { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ServerCreate { get; set; }
        public string ServerUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Country Country { get; set; }
        public virtual Position Position { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
