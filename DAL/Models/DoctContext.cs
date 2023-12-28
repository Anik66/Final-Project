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
        public DbSet<Doctor> Doctors { get; set; }
    }
}
