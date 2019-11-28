//using DTOs;
using System;
using System.Collections.Generic;
using System.Text;



namespace DataAccessLayer
{
    public interface IUserMenager
    {
        DTOs.User GetUser(int Id);
        int LogInUser(string username, string password);
        int RegisterUser(DTOs.User loginUser, DateTime lastUpdated);
        bool CheckIfUserExists(string username);
        //void AddToCart (int id, DTOs.)
    }
}
