using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Teady Bear", Price = 10},
            new Product {Id = 2, Name = "Shirt", Price = 15},
            new Product {Id = 3, Name = "CoolSkirt", Price = 20}
        };

        [HttpGet]
        public ActionResult<Product[]> GetProducts()
        {
            return Ok(products);
        }

        [HttpGet("{id}/hystory")]
        public ActionResult<Product> GetProductHistory(int id)
        {
            return Ok("Return Product history for id " + id);
        }
    }
}