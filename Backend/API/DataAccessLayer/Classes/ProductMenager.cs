using AutoMapper;
using DBUnitOfWork;
using EntityModels;
using System;
using DTOs;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccessLayer
{
    public class ProductMenager : IProductMenager
    {
        private IMapper _mapper;

        public ProductMenager(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public DTOs.Products GetProducts(SearchBy Search)
        {
            using (APShopContext context = new APShopContext())
            { 
                UnitOfWork UoW = new UnitOfWork(context);

                DTOs.Products listOfProducts = new DTOs.Products() { ArrayOfProducts = new List<DTOs.Product>() };
                List<EntityModels.Product> products = UoW.Product.GetBySearch(Search);

               foreach(var product in products)
                {
                    listOfProducts.ArrayOfProducts.Add(_mapper.Map<DTOs.Product>(product));
                }

                return listOfProducts;
            }


        }
        public DTOs.FullProduct GetFullProduct(int id)
        {
            using (APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);
                DTOs.FullProduct fullProduct = new DTOs.FullProduct();

                var FullP = UoW.Product.GetEntireProductById(id);
                var FullPD = FullP.ProductDetails.SingleOrDefault();

                if (FullP == null)
                {
                    return fullProduct;
                }

                fullProduct.product = _mapper.Map<DTOs.Product>(FullP);
                fullProduct.productDetails = _mapper.Map<DTOs.ProductDetails>(FullPD);
                return fullProduct;
            }
        }

        public void AddProduct(DTOs.Product product, DTOs.ProductDetails productDetails)
        {
            using (APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);
                EntityModels.Product EMProduct = _mapper.Map<EntityModels.Product>(product);
                EntityModels.ProductDetails EMProductDetails = _mapper.Map<EntityModels.ProductDetails>(productDetails);

                UoW.Product.AddProduct(EMProduct);
                EMProduct.ProductDetails.Add(EMProductDetails);

                UoW.commit();
                
            }
        }

        public bool UpdateProduct(DTOs.Product product, DTOs.ProductDetails productDetails)
        {
            using (APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);
                EntityModels.Product EMProduct = _mapper.Map<EntityModels.Product>(product);
                EntityModels.ProductDetails EMProductDetails = _mapper.Map<EntityModels.ProductDetails>(productDetails);

                var Exists = UoW.Product.GetByCode(product.Code);

                if (Exists != null)
                {
                    Exists.IsActive = false;
                    UoW.Product.AddProduct(EMProduct);
                    EMProduct.ProductDetails.Add(EMProductDetails);
                    UoW.commit();
                    return true;
                }
                else return false;
            }
        }

        public bool DeleteProduct(string code)
        {
            using (APShopContext context = new APShopContext())
            {
                UnitOfWork UoW = new UnitOfWork(context);

                if (code != null)
                {
                    var Delete = UoW.Product.DeleteProduct(code);
                    if (Delete) return true;
                    else return false;
                }

                else return false;
            }
        }
    }
}
