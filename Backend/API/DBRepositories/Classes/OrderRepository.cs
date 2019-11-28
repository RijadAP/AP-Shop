using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<EntityModels.Order> GetAllOrders(int id)
        {
            if (id != 0)
            {
                return _dbSet.Include("OrderProduct.Order").Include("Product").Where(p => p.UserId == id).ToList();
            }
            else
            {
                return new List<Order>();
            }
        }
    }
}
