using System;
using System.Collections.Generic;

namespace EntityModels
{
    public partial class Product
    {
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
            ProductDetails = new HashSet<ProductDetails>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string ShortDescription { get; set; }
        public double Price { get; set; }
        public double ShippingPrice { get; set; }

        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
