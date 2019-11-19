using EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBRepositories
{
    public class UserRepository : IUserRepository
    {
        private DbSet<Users> _dbSet;

        public UserRepository (APShopContext context)
        {
            this._dbSet = context.Users;
        }

        public Users GetById (int id)
        {
            return _dbSet.SingleOrDefault(u => u.Id == id);
        }

        public int LogIn(string username, string password)
        {
            try
            {
                return _dbSet.SingleOrDefault(u => u.Username == username && u.Password == password).Id;
            }
            catch (Exception)
            {
                throw new Exception("User not found");
            }

            
        }

        public void Register(Users user)
        {
            _dbSet.Add(user);
        }

        public bool CheckIfUserExists(string username)
        {
            return _dbSet.Any(u => u.Username == username);
        }
    }
}
