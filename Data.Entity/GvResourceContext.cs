using System;
using Data.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Entity
{
    public partial class GvResourceContext : DbContext
    {
        public GvResourceContext()
        {
        }

        public GvResourceContext(DbContextOptions<GvResourceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<JobTitle> JobTitles { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=GVRS_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryName).HasMaxLength(200);

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.CountryName).HasMaxLength(200);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Country_Customer");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_Position_Customer");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_Province_Customer");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeName).HasMaxLength(200);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(20)
                    .HasColumnName("IDCard");

                entity.Property(e => e.Idno)
                    .HasMaxLength(20)
                    .HasColumnName("IDNo");

                entity.Property(e => e.JobTitleId).HasColumnName("JobTitleID");

                entity.Property(e => e.PassportNo).HasMaxLength(20);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Employee_Suppliers");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobTitleId)
                    .HasConstraintName("FK_Employee_JobTitle");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_Employee_Position");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_Employee_Province");
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.ToTable("JobTitle");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.JobTitleName).HasMaxLength(200);

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.CountryName).HasMaxLength(200);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.ShipAddress).HasMaxLength(200);

                entity.Property(e => e.ShipCity).HasMaxLength(200);

                entity.Property(e => e.ShipPostalCode).HasMaxLength(200);

                entity.Property(e => e.ShipProvince).HasMaxLength(200);

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Employee_Customer");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Orders_Employee");

                entity.HasOne(d => d.Shipper)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShipperId)
                    .HasConstraintName("FK_Employee_Shipper");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetail_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.PositionName).HasMaxLength(200);

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Product_Supplier");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceName).HasMaxLength(200);

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.ToTable("Shipper");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(12);

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.ShipperName).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.ContractCode).HasMaxLength(200);

                entity.Property(e => e.ContractName).HasMaxLength(200);

                entity.Property(e => e.ContractTitle).HasMaxLength(200);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.ServerCreate).HasMaxLength(200);

                entity.Property(e => e.ServerUpdate).HasMaxLength(200);

                entity.Property(e => e.SupplierName).HasMaxLength(200);

                entity.Property(e => e.UserCreate).HasMaxLength(200);

                entity.Property(e => e.UserUpdate).HasMaxLength(200);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Country_Supplier");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_Position_Supplier");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_Province_Supplier");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
