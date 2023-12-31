using DAL.Interfaces;
using DAL.Models.Patient_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AppointmentRepo : Repo, IRepo<Appointment, int, bool>
    {
        public bool Delete(int id)
        {
            var appointment = Get(id);
            db.Appointments.Remove(appointment);
            return db.SaveChanges() > 0;
        }

        public List<Appointment> Get()
        {
            return db.Appointments.ToList();
        }

        public Appointment Get(int id)
        {
            return db.Appointments.Find(id);
        }

        public bool Insert(Appointment obj)
        {
            db.Appointments.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Appointment obj)
        {
            var exorder = Get(obj.Id);
            db.Entry(exorder).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
