using System.ComponentModel.DataAnnotations;

namespace CRUDForMySQLWithEFCore
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Price { get; set; }
    }
}
