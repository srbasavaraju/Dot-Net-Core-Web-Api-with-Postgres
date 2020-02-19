using System;

namespace WebApiWithPostGress.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public DateTime DOB { get; set; }
    }
}
