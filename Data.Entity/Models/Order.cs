using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entity.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string CountryName { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipProvince { get; set; }
        public string ShipPostalCode { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Guid? ShipperId { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? CustomerId { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ServerCreate { get; set; }
        public string ServerUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
