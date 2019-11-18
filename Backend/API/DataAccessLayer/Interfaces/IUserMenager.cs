//using DTOs;
using System;
using System.Collections.Generic;
using System.Text;



namespace DataAccessLayer
{
    public interface IUserMenager
    {
        DTOs.User GetUser(int Id);
        int RegisterUser(DTOs.User loginUser);
    }
}
