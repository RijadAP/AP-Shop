using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Interfaces
{
    public interface IProductMenager
    {
        DTOs.Product GetProduct(String Search);
    }
}
