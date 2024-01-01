using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Patient_DTO
{
    public class PatientDTO
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public double Balance { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Blood_Gloup { get; set; }
    }
}
