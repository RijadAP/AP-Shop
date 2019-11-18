using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBRepositories
{
    class ProductRepository : IProductRepository
    {

        private DbSet<Product> _dbSet;
        public ProductRepository(APShopContext context)
        {
            this._dbSet = context.Product;
        }

        public Product GetById(object id)
        {
            return _dbSet.SingleOrDefault(u => u.Id == (int)id);
        }

        public List<Product> GetByName(string name)
        {
            return _dbSet.Where(u => u.Name == name).ToList();
        }
    }
}
