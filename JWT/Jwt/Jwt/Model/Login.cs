﻿using System;
using System.Collections.Generic;

namespace Jwt.Model
{
    public partial class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
