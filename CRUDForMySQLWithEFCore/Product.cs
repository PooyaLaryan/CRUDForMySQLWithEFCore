using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CRUDForMySQLWithEFCore
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Price { get; set; }
    }

    class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(nameof(Product.Id));
            builder.Property(x => x.ProductName).HasColumnName(nameof(Product.ProductName));
            builder.Property(x => x.Price).HasColumnName(nameof(Product.Price));
        }
    }
}
