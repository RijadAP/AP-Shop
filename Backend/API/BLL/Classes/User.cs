using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class User : IUser
    {
        private IUserMenager _userMenager;

        public User(IUserMenager userMenager)
        {
            this._userMenager = userMenager;
        }
        public bool CheckIfUSerExists(string username)
        {
            return _userMenager.CheckIfUserExists(username);
        }
    }
}
