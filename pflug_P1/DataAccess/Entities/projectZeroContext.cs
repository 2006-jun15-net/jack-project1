using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Entities
{
    public partial class projectZeroContext : DbContext
    {
        public projectZeroContext()
        {
        }

        public projectZeroContext(DbContextOptions<projectZeroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrder { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<OrderHistory> OrderHistory { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<StoreLocation> StoreLocation { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CustomerOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                            .HasName("PK__customer__C3905BCFCF0AB048");

                entity.ToTable("customerOrder");

                entity.Property(e => e.AmountPurchased).HasColumnName("amountPurchased");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName).HasMaxLength(30);

                entity.HasOne(d => d.LocationNameNavigation)
                    .WithMany(p => p.CustomerOrder)
                    .HasForeignKey(d => d.LocationName)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_customerOrder_LocationName");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerOrder)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__customerO__Produ__5AB9788F");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LocationName).HasMaxLength(30);

                entity.HasOne(d => d.LocationNameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.LocationName)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Inventory__Locat__57DD0BE4");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Inventory__Produ__56E8E7AB");
            });

            modelBuilder.Entity<OrderHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LocationName).HasMaxLength(30);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.ProductName).HasMaxLength(30);

                entity.HasOne(d => d.Customer)
                    .WithMany()
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__OrderHist__Custo__5D95E53A");

                entity.HasOne(d => d.LocationNameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.LocationName)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__OrderHist__Locat__5E8A0973");

                entity.HasOne(d => d.ProductNameNavigation)
                    .WithMany()
                    .HasPrincipalKey(p => p.ProductName)
                    .HasForeignKey(d => d.ProductName)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__OrderHist__Produ__5CA1C101");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__OrderIte__B40CC6CD2DAB26A3");

                entity.HasIndex(e => e.ProductName)
                    .HasName("UQ__OrderIte__DD5A978AEB87BF3F")
                    .IsUnique();

                entity.Property(e => e.Price).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<StoreLocation>(entity =>
            {
                entity.HasKey(e => e.LocationName)
                    .HasName("PK__storeLoc__930DB017D5958718");

                entity.ToTable("storeLocation");

                entity.Property(e => e.LocationName)
                    .HasColumnName("locationName")
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
