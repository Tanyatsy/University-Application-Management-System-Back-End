﻿using System;

namespace Unipply.Models.User
{
    public class UserData
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
