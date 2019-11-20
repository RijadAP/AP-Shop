using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTOs;
using EntityModels;
using DataAccessLayer;
using BLL;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private APShopContext _context;

        //public UserController(APShopContext context) => _context = context;

        private readonly IUserMenager _usermenager;
        private readonly IUser _user;
        private readonly IValidation _validation;

        public UserController(IUserMenager userMenager, IUser user, IValidation validation)
        {
            this._usermenager = userMenager;
            this._user = user;
            this._validation = validation;
        }

        // GET      api/User
        //    [HttpGet]
        //    public ActionResult<IEnumerable<Users>> GetUsers()
        //    {
        //        return _context.Users;
        //    }

        //    [HttpGet("{userId}")]
        //    public Users GetUserByID(int userId)
        //    {
        //        return _context.Users.SingleOrDefault(u => u.Id == userId);
        //    }


        [HttpGet]
        public ActionResult GetLogin(string username, string password)
        {
            bool isValid = _validation.ValidateLogin(username, password);

            if (isValid)
            {
                int UserId = _usermenager.LogInUser(username, password);

                if (UserId == 0)
                {
                    return BadRequest("Login info is wrong");
                }
                return Ok(UserId);
            }
            else
            {
                return BadRequest("Invalid Input!");
            }

        }

        [HttpGet("{userId}")]
        public IActionResult GetById(int userId)
        {
            DTOs.User user = _usermenager.GetUser(userId);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Reggister ([FromBody]DTOs.User user)
        {
            if (user == null)
            {
                return BadRequest("User info was not provided!");
            }
            int result;

            try
            {
                var currentDate = DateTime.Now;
                result = _usermenager.RegisterUser(user, currentDate);
            }
            catch (ArgumentNullException)
            {
                BadRequest("NoUser");
            }
            return Ok("Succesfull registration " + user.Id);
        }


     

    }
}