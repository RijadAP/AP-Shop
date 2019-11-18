using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositories
{
    class CartRepository : ICartRepository
    {

        private DbSet<Cart> _dbSet;
        public CartRepository(APShopContext context)
        {
            this._dbSet = context.Cart;
        }
        public void CreateCart(Cart cart)
        {
            _dbSet.Add(cart);
        }

        //public Cart GetById(object id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
