using DAL.Models;
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
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppDetail> AppDetails { get; set; }
        public DbSet<Fee> Fees { get; set; }
    }
}
