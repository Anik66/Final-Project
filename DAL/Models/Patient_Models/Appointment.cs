using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Fee { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string Chember_Address { get; set; }
        public string Status { get; set; }

        [Required, ForeignKey("Manager")]
        public string MngMail { get; set; }

        public virtual Manager Manager { get; set; }
        public virtual ICollection<Fee> Fees { get; set; }
        public virtual ICollection<AppDetail> AppDetails { get; set; }
        public Appointment()
        {
            AppDetails = new List<AppDetail>();
            Fees = new List<Fee>();
        }
    }
}
