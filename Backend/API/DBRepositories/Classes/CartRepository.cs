using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositories
{
    public class CartRepository : ICartRepository
    {

        private DbSet<Cart> _dbSet;
        public CartRepository(APShopContext context)
        {
            _dbSet = context.Cart;
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
