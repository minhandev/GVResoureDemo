using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entity.Models
{
    public partial class Country
    {
        public Country()
        {
            Customers = new HashSet<Customer>();
            Employees = new HashSet<Employee>();
            Suppliers = new HashSet<Supplier>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string CountryName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ServerCreate { get; set; }
        public string ServerUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
