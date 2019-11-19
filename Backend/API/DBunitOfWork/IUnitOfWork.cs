using DBRepositories;
using DTOs;
using EntityModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace DBUnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        IOrderRepository Order { get; }
        ICartRepository Cart { get; }

        void commit();
    }
}
