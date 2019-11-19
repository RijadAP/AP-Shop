using EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepositories
{
    public interface IUserRepository
    {
        int LogIn(string username, string password);
        void Register(Users user);
        Users GetById(int id);
        bool CheckIfUserExists(string username);
    }
}
