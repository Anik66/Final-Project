using DAL.Models.Patient_Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class DoctContext:DbContext
    {
        //Doctor
        public DbSet<Doctor> Doctors { get; set; }

        //Patient
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
