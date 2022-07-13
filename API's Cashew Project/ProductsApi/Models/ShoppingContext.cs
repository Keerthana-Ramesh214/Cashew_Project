using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProductsApi.Models
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

        public virtual DbSet<Product> Products { get; set; }

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
