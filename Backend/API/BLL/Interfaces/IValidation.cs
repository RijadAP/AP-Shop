using DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IValidation
    {
        bool ValidateLogin(string username, string password);
        bool ValidateProductUpdate(Product product, ProductDetails productDetails);
        bool CheckIfUserExists(DTOs.User user);
    }
}
