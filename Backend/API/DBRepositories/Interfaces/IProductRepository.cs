using EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositories
{
    public interface IProductRepository
    {
        Product GetById(object id);

        Product GetEntireProductById(int id);

        List<Product> GetByName(string name);

        List<Product> GetBySearch(DTOs.SearchBy user);

        Product GetByCode(string code);
        void AddProduct(Product product);
        bool DeleteProduct(string code);

        bool CheckProduct(int Id); //If it exists
        bool CheckProductIsAvailable(int id, int quantity); //Check if product is activ as well as checks if its in stock
        void ReduceInStock(int ProductId, int quantity);
    }
}
