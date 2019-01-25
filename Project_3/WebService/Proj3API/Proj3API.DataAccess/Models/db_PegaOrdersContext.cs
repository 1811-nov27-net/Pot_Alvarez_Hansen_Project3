using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Proj3API.Models
{
    public partial class Db_PegaOrdersContext : DbContext
    {
        public Db_PegaOrdersContext()
        {
        }

        public Db_PegaOrdersContext(DbContextOptions<Db_PegaOrdersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderHeaders> OrderHeaders { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company", "PB");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice", "PB");

                entity.HasOne(d => d.OrderHeader)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.OrderHeaderId);
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.ToTable("Logs", "PB");

                entity.Property(e => e.LogLevel).HasMaxLength(100);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail", "PB");

                entity.HasOne(d => d.OrderHeader)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.OrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderHeaders>(entity =>
            {
                entity.ToTable("OrderHeaders", "PB");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.HasOne(d => d.BillingPerson)
                    .WithMany(p => p.OrderHeadersBillingPerson)
                    .HasForeignKey(d => d.BillingPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderHeaders_People");

                entity.HasOne(d => d.ShippingPerson)
                    .WithMany(p => p.OrderHeadersShippingPerson)
                    .HasForeignKey(d => d.ShippingPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.ToTable("People", "PB");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnName("ZIPCode")
                    .HasMaxLength(10);

                entity.HasOne(d => d.CompanyName)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.CompanyNameId)
                    .HasConstraintName("FK_People_Company_CompanyId");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.ToTable("ProductType", "PB");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("Products", "PB");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ProductType)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductTypeId);
            });
        }
    }
}
