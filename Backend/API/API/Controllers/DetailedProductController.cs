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
    public class DetailedProductController : ControllerBase
    {
        [HttpGet("{id}")]
        ActionResult<FullProduct> GetProductDetails()
        {
            return Ok("Get product details using id " + id);
        }

        [HttpPost]
        ActionResult PostProductDetails ([FromBody] FullProduct product)
        {
            return Ok("Post product details");
        }

        [HttpPut("{id}")]
        ActionResult PutPeoductDetail(int id, [FromBody] FullProduct product)
        {
            return Ok("Put product detail" + id);
        }

        [HttpDelete("{id}")]
        ActionResult DeleteProductDetail (int id)
        {
            return Ok("Delete product detail " + id);
        }
    }
}