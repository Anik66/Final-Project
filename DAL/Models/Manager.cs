using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Models
{
    public class Manager
    {
        [Key]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
        [Required]
        [StringLength(10)]
        public string Address { get; set; }
        [Required]
        [StringLength(11)]
        public string Phonenumber { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        
        public Manager()
        {
            Appointments = new List<Appointment>();
        }
    }
}
