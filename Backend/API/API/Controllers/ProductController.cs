using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer;
using BLL;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private Product[] products = new Product[]
        //{
        //    new Product {Id = 1, Name = "Teady Bear", Price = 10},
        //    new Product {Id = 2, Name = "Shirt", Price = 15},
        //    new Product {Id = 3, Name = "CoolSkirt", Price = 20}
        //};

        private readonly IProductMenager _productMenager;
        private readonly IValidation _validation;

        public ProductController(IProductMenager productMenager, IValidation validation)
        {
            _productMenager = productMenager;
            _validation = validation;
        }


        [HttpGet]
        public ActionResult<Products> GetProducts(string search, int category, int gender, int condition, int fromPrice, int toPrice, bool freeshipping)
        {
            var SearchBy = new SearchBy()
            {
                Search = search,
                Categories = (Filters.Categories)category,
                Gender = (Filters.Genders)gender,
                Condition = (Filters.Conditions)condition,
                PriceRange = new Filters.PriceRange() { From = fromPrice, To = toPrice },
                FreeShippig = freeshipping
            };

            var ListOfProducts = _productMenager.GetProducts(SearchBy);
            return Ok(ListOfProducts);
        }

        //[HttpPost]
        //public ActionResult AddProduct ([FromBody]FullProduct product)
        //{
        //    if (product != null)
        //    {
        //        product.productDetails
        //    }
        //}

     
    }
}