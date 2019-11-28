using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private IOrderMenager _orderMenager;
        private ICurrentDate _currentDate;

        public OrderController(IOrderMenager orderMenager, ICurrentDate currentDate)
        {
            _orderMenager = orderMenager;
            _currentDate = currentDate;
        }


        [HttpPost("{id}")]
        public ActionResult AddOrder (int id, [FromBody] Order order)
        {
            if (order != null)
            {
                order.Date = _currentDate.GetDate();
                order.TotalPrice = 100;
                try
                {
                    var addResult = _orderMenager.AddOrder(id, order);
                }
                catch (Exception error)
                {
                    return BadRequest(error.Message);
                }
                return Ok("Purchase Successfull!");
            }
            else return BadRequest("No order provided!");
        }
    }
}