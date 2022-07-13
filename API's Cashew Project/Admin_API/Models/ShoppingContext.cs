using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Admin_API.Models
{
    public partial class ShoppingContext : DbContext
    {
        public ShoppingContext()
        {
        }

        public ShoppingContext(DbContextOptions<ShoppingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminDetail> AdminDetails { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<UserRegistration> UserRegistrations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Shopping;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdminDetail>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__AdminDet__719FE48824C16B2B");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Admin_Name");

                entity.Property(e => e.AdminPassword)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Admin_Password");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__OrderDet__C3905BCF996709BD");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderDeliveryDate).HasColumnType("date");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("Product_Id");

                entity.Property(e => e.ProductDescription)
                    .IsUnicode(false)
                    .HasColumnName("Product_Description");

                entity.Property(e => e.ProductImage)
                    .IsUnicode(false)
                    .HasColumnName("Product_Image");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPrice).HasColumnName("Product_Price");
            });

            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Shopping__3FB5087468F25F15");

                entity.ToTable("ShoppingCart");

                entity.Property(e => e.ItemId)
                    .ValueGeneratedNever()
                    .HasColumnName("Item_Id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPrice).HasColumnName("Product_Price");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("Total_Price")
                    .HasComputedColumnSql("([Product_Price]*[Quantity])", false);
            });

            modelBuilder.Entity<UserRegistration>(entity =>
            {
                entity.HasKey(e => e.PhoneNumber)
                    .HasName("PK__UserRegi__85FB4E39AE91063A");

                entity.ToTable("UserRegistration");

                entity.Property(e => e.PhoneNumber).ValueGeneratedNever();

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Pass_Word");

                entity.Property(e => e.UserName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
