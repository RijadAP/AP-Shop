﻿using System;
using System.Collections.Generic;

namespace EntityModels
{
    public partial class Cart
    {
        public Cart()
        {
            CartProduct = new HashSet<CartProduct>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DateLastUpdated { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<CartProduct> CartProduct { get; set; }
    }
}
