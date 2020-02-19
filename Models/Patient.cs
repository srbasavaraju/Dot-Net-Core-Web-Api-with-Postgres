using System;

namespace WebApiWithPostGress.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string mrn { get; set; }
        public DateTime DOB { get; set; }
    }
}
