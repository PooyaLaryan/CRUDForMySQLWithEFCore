using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDForMySQLWithEFCore
{
    public class Order
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }

    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(nameof(Order));
            builder.HasKey(t => t.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.OwnsOne(x => x.Address, o =>
            {
                o.WithOwner();
            });
        }
    }
}
