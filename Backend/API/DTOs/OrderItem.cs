using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public FullProduct product { get; set; }
        public int Quantity { get; set; }
    }
}
