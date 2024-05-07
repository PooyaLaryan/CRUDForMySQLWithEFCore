using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDForMySQLWithEFCore
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; } 
        public Order Order { get; set; }
    }

    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable(nameof(OrderDetail));

            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).IsRequired();
            builder.Property(x => x.OrderId).HasColumnName(nameof(OrderDetail.OrderId));
            builder.Property(x => x.ProductId).HasColumnName(nameof(OrderDetail.ProductId));

            builder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId);
            
            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.OrderId);
        }
    }
}
