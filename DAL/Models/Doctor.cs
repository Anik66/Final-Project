using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Doctor
    {
        [Key, Required]
        [StringLength(15)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string Uname { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(6)]
        public string Password { get; set; }
        [Required]
        [StringLength(10)]
        public string Age { get; set; }
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
        [Required]
        [StringLength(10)]
        public string BloodGroup { get; set; }
        [Required]
        [StringLength(10)]
        public string Address { get; set; }
        [Required]
        [StringLength(11)]
        public string Phonenumber { get; set; }
    }
}
