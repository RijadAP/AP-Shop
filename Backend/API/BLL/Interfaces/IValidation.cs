using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IValidation
    {
        bool ValidateLogin(string username, string password);
    }
}
