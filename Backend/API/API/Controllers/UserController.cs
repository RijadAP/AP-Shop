using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTOs;
using EntityModels;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private APShopContext _context;

        public UserController(APShopContext context) => _context = context;

        // GET      api/User
        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetUsers()
        {
            return _context.Users;
        }

        [HttpGet("{userId}")]
        public Users GetUserByID(int userId)
        {
            return _context.Users.SingleOrDefault(u => u.Id == userId);
        }

    }
}