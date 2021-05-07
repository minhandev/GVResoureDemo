using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entity.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string EmployeeName { get; set; }
        public string Idno { get; set; }
        public string Idcard { get; set; }
        public string PassportNo { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string FilePath { get; set; }
        public Guid? DepartmentId { get; set; }
        public Guid? JobTitleId { get; set; }
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
        public virtual JobTitle JobTitle { get; set; }
        public virtual Position Position { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
