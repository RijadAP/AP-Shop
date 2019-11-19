using EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositories
{
    public interface IProductRepository
    {
        Product GetById(object id);
        List<Product> GetByName(string name);
    }
}
