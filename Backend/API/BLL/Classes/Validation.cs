using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Validation : IValidation
    {

        public readonly IUser _user;
        public Validation(IUser user)
        {
            _user = user;
        }


        public bool ValidateLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return false;
            return true;
        }

        public bool CheckIfUserExists(DTOs.User user)
        {
            var exists = ValidateLogin(user.Username, user.Password);
            if (!exists || user.Role == 0)
            {
                return false;
            }
            else return _user.CheckIfUSerExists(user.Username);
        }

        public bool ValidateProductUpdate(DTOs.Product product, DTOs.ProductDetails productDetails)
        {
            return true;
        }



    }
}
