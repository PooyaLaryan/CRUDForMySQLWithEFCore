﻿namespace CRUDForMySQLWithEFCore
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; } 
        public Order Order { get; set; }
    }
}
