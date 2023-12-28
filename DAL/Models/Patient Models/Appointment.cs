using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Patient_Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Dr_Name { get; set; }
        public string Specialist { get; set; }
        public string DateTime { get; set; }
        public string Chember_Address { get; set; }
    }
}
