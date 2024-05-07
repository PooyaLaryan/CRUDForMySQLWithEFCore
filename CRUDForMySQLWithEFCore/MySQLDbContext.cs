using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDForMySQLWithEFCore
{
    public class MySQLDbContext : DbContext
    {
        public MySQLDbContext(DbContextOptions<MySQLDbContext> dbContextOptions) : base(dbContextOptions) 
        {
            
        }
        public DbSet<Product> Products { get; set; }  
        public DbSet<Order> Orders { get; set; }   
        public DbSet<Address> Addresss { get; set; } 
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new OrderDetailConfig());
        }
    }
}
