using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DoctorRepo : Repo, IRepo<Doctor, string, Doctor>
    {
        public Doctor Create(Doctor obj)
        {
           db.Doctors.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Doctors.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Doctor> Read()
        {
            return db.Doctors.ToList();
        }

        public Doctor Read(string id)
        {
            return db.Doctors.Find(id);
        }

        public Doctor Update(Doctor obj)
        {
            var ex = Read(obj.Uname);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
         }
    }
}
