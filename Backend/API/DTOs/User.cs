﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }


    public class Roles
    {
        public enum AllRoles
        {
            Administrator = 1,
            User = 2
        }
    }
}
