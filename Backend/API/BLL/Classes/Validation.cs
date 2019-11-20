using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Validation : IValidation
    {
        public bool ValidateLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return false;
            return true;
        }
    }
}
