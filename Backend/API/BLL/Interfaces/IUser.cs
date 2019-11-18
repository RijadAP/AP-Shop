using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    interface IUser
    {
        bool CheckIfUSerExists(string username);
    }
}
