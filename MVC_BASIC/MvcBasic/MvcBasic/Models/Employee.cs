﻿using System;
using System.Collections.Generic;

namespace MvcBasic.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }
}
