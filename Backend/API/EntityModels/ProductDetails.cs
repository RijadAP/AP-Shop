using System;
using System.Collections.Generic;

namespace EntityModels
{
    public partial class ProductDetails
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime DatePublished { get; set; }
        public string Condition { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string PublishedBy { get; set; }
        public string ShippingFrom { get; set; }

        public virtual Product Product { get; set; }
    }
}
