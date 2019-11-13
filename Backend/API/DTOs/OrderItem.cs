using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Product prroduct { get; set; }
        public int Quantity { get; set; }
    }
}
