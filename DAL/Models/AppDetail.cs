using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DAL.Models.Patient_Models;

namespace DAL.Models
{
    public class AppDetail
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public double DoctorFees { get; set; }
        [Required]
        [ForeignKey("Appointment")]
        public int AppId { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public string DcMail { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}