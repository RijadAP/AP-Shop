using System;
using System.Collections.Generic;
using System.Text;
using DTOs;

namespace DataAccessLayer
{
    public interface IProductMenager
    {
        DTOs.Products GetProducts(SearchBy Search);
        void AddProduct(Product product, ProductDetails productDetails);
        bool UpdateProduct(Product product, ProductDetails productDetails);
        bool DeleteProduct(string code);
        FullProduct GetFullProduct(int id);
    }
}
