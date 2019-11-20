using AutoMapper;
using DBUnitOfWork;
using EntityModels;
using System;
using DTOs;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class ProductMenager : IProductMenager
    {
        private IMapper _mapper;

        public ProductMenager(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public DTOs.Products GetProduct(String Search)
        {
            using (APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);

                DTOs.Products listOfProducts = new DTOs.Products() { ArrayOfProducts = new List<DTOs.Product>() };
                List<EntityModels.Product> products = UoW.Product.GetByName(Search);

               foreach(var product in products)
                {
                    listOfProducts.ArrayOfProducts.Add(_mapper.Map<DTOs.Product>(product));
                }

                return listOfProducts;
            }
        }
    }
}
