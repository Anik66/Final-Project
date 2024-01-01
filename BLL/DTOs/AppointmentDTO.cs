using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Dr_Name { get; set; }
        [Required]
        [StringLength(10)]
        public string Specialist { get; set; }
        [Required]
        [StringLength(10)]
        public string Fee { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        [StringLength(15)]
        public string Chember_Address { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        [Required]
        public string MngMail { get; set; }
    }
}
