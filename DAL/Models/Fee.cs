using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Fee
    {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public double Paid { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        [ForeignKey("Patient")]
        public int PId { get; set; }
        [Required]
        [ForeignKey("Appointment")]
        public int AId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}
