using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public float TotalPrice { get; set; }
        public OrderItem[] Items { get; set; }
    }
}
