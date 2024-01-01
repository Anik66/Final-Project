using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PatientDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(5)]
        public string Age { get; set; }
        [Required]
        [StringLength(5)]
        public string Gender { get; set; }
        [Required]
        [StringLength(5)]
        public string BloodGroup { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(20)]
        public string Address { get; set; }
        [Required]
        public double Balance { get; set; }
    }
}
