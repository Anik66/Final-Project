using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Patient_Models
{
    public class Patient
    {
        [Key]
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
        [StringLength(10)]
        public string Gender { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        public double Balance { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Blood_Gloup { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }

        public Patient()
        {
            this.Balance = 0;
            Fees = new List<Fee>();
        }
    }
}
