using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IProductMenager
    {
        DTOs.Product GetProduct(String Search);
    }
}
