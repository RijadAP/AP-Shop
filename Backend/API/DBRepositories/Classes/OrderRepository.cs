using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositories
{
    public class OrderRepository : IOrderRepository
    {
        private DbSet<Order> _dbSet;
        public OrderRepository(APShopContext context)
        {
            this._dbSet = context.Order;
        }

        public Order GetById (object id)
        {
            throw new NotImplementedException();
        }
    }
}
