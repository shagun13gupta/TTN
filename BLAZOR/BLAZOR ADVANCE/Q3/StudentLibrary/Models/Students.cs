using System;
using System.Collections.Generic;

namespace StudentApi.Models
{
    public partial class Students
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Course { get; set; }
        public string Address { get; set; }
    }
}
