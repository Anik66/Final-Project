using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Patient_DTO
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public string Dr_Name { get; set; }
        public string Specialist { get; set; }
        public string Fee { get; set; }
        public string DateTime { get; set; }
        public string Chember_Address { get; set; }
    }
}
