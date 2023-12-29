using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HMSContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Token> Tokens { get; set; }
    }
}
