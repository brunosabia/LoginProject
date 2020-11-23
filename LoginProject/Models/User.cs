﻿using LoginProject.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginProject.Models
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Status Status { get; set; }

        public User() { }

        public User(string username, string password, Status status)
        {
            Username = username;
            Password = password;
            Status = status;
        }
    }
}
