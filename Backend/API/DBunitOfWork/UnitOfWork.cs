using DBRepositories;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBUnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly APShopContext _context;
        private UserRepository _user;
        private ProductRepository _product;
        private CartRepository _cart;
        private OrderRepository _order;

        public UnitOfWork(APShopContext context)
        {
            if (context == null) throw new ArgumentNullException();
            this._context = context;
        }

         public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_context);
                }
                return _user;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_context);
                }
                return _product;
            }
        }

        public ICartRepository Cart
        {
            get
            {
                if (_cart == null)
                {
                    _cart = new CartRepository(_context);
                }
                return _cart;
            }
        }

        public IOrderRepository Order
        {
            get
            {
                if (_order == null)
                {
                    _order = new OrderRepository(_context);
                }
                return _order;
            }
        }

        public void commit()
        {
            _context.SaveChanges();
        }

    }
}
