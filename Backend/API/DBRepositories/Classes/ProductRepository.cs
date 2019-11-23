using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBRepositories
{
    public class ProductRepository : IProductRepository
    {

        private DbSet<Product> _dbSet;
        private APShopContext _context;
        public ProductRepository(APShopContext context)
        {
            this._dbSet = context.Product;
            this._context = context;
        }

        public Product GetById(object id)
        {
            return _dbSet.SingleOrDefault(u => u.Id == (int)id);
        }

        public Product GetEntireProductById(int id)
        {
            return _dbSet.Include("ProductDetails.Product").SingleOrDefault(p => p.Id == id);
        }

        public List<Product> GetByName(string name)
        {
            return _dbSet.Where(u => u.Name == name).ToList();
        }

        public Product GetByCode(string code)
        {
            return _dbSet.SingleOrDefault(p => p.Code == code);
        }

        //public List<Product> GetBySearch(DTOs.SearchBy searchBy)
        //{
        //    var query = _context.Product.AsQueryable();

        //    if (searchBy.Search != null)
        //    {
        //        query = query.Where(p => p.Name.Contains(searchBy.Search));
        //    }
        //    if (searchBy.Category > 0)
        //    {
        //        query = query.Where(p => p.ProductDetails.SingleOrDefault().Model == (int)searchBy.Category);
        //    }
        //    if (searchBy.Gender > 0)
        //    {
        //        query = query.Where(p => p.ProductDetails.SingleOrDefault().Gender == (int)searchBy.Gender);
        //    }
        //    if (searchBy.Condition > 0)
        //    {
        //        query = query.Where(p => p.ProductDetails.SingleOrDefault().Condition == (int)searchBy.Condition);
        //    }
        //    if (searchBy.FreeShipping == true)
        //    {
        //        query = query.Where(p => p.ShippingPrice == 0);
        //    }
        //    if (searchBy.PriceRange.FromPrice > 0 && searchBy.PriceRange.ToPrice > 0)
        //    {
        //        query = query.Where(p => p.Price > (decimal)searchBy.PriceRange.FromPrice && p.Price < (decimal)searchBy.PriceRange.ToPrice);
        //    }
        //    return query.AsNoTracking().OrderBy(p => p.Name).ToList();
        //}

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new Exception("Product was not provided!");
            }

            _context.Product.Add(product);
            //_dbSet.Add(product);
        }

        public bool DeleteProduct(string code)
        {
            var product = GetByCode(code);
            if (product != null)
            {
                product.IsActive = false;
                return true;
            }

            return false;
        }

        public bool CheckProduct(int Id)
        {
            return _dbSet.Any(p => p.Id == Id && p.IsActive == true);
        }
    }
}
