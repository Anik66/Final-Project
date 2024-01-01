using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Appointment
    {
        [Key]
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
