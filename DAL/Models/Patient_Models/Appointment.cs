using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Patient_Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Dr_Name { get; set; }
        [Required]
        public string Specialist { get; set; }
        [Required]
        public string DateTime { get; set; }
        [Required]
        public string Chember_Address { get; set; }
    }
}
