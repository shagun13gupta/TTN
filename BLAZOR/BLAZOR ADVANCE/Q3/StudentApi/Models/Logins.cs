using System;
using System.Collections.Generic;

namespace StudentApi.Models
{
    public partial class Logins
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
