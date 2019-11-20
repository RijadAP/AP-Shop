using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IUser
    {
        bool CheckIfUSerExists(string username);
    }
}
