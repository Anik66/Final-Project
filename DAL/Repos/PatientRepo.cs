using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PatientRepo : Repo, IRepo<Patient, int, bool>
    {
        public bool Delete(int id)
        {
            var Patient = Get(id);
            db.Patients.Remove(Patient);
            return db.SaveChanges() > 0;
        }

        public List<Patient> Get()
        {
            return db.Patients.ToList();
        }

        public Patient Get(int id)
        {
            return db.Patients.Find(id);
        }

        public bool Insert(Patient obj)
        {
            db.Patients.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Patient obj)
        {
            var exorder = Get(obj.Id);
            db.Entry(exorder).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
