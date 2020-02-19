﻿using System.Collections.Generic;

namespace WebApiWithPostGress.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
