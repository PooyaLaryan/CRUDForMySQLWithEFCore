namespace CRUDForMySQLWithEFCore
{
    public class Order
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        IEnumerable<OrderDetail> Details { get; set; } = new List<OrderDetail>();
    }
}
