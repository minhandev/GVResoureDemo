using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entity.Models
{
    public partial class OrderDetail
    {
        public Guid Id { get; set; }
        public int? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public double? Discount { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Guid? OrderId { get; set; }
        public Guid? ProductId { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ServerCreate { get; set; }
        public string ServerUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
