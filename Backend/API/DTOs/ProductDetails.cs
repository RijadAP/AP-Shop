﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime DatePublished { get; set; }
        public int Condition { get; set; }
        public int Gender { get; set; }
        public int Color { get; set; }
        public int Model { get; set; }
        public string PublishedBy { get; set; }
        public string ShippingFrom { get; set; }

    }
}
