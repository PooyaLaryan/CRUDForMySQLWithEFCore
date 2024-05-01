using Microsoft.EntityFrameworkCore;

namespace CRUDForMySQLWithEFCore
{
    public class MySQLDbContext : DbContext
    {
        public MySQLDbContext(DbContextOptions<MySQLDbContext> dbContextOptions) : base(dbContextOptions) 
        {
            
        }
        public DbSet<Products> Products { get; set; }  
    }
}
