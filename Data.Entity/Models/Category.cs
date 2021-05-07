using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entity.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string FilePath { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateCreate { get; set; }
        public string ServerCreate { get; set; }
        public string ServerUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public bool? IsDelete { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
