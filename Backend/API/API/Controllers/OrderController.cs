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
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public ActionResult PostOrder ([FromBody] Order order)
        {
            if (true)
            {
                return Ok("Purchase successfull");
            } 
            else
            {
                return Ok("Purchase not successfull");
            }
        }
    }
}