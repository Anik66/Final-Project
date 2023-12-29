using DAL.Interfaces;
using DAL.Models;
using DAL.Models.Patient_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PatientRepo : Repo, IRepo<Patient, string, Patient>
    {
        public Patient Create(Patient obj)
        {
            db.Patients.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public List<Patient> Read()
        {
            return db.Patients.ToList();
        }

        public Patient Read(string id)
        {
            return db.Patients.Find(id);
        }

        public Patient Update(Patient obj)
        {
            var ex = Read(obj.Name);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Patients.Remove(ex);
            return db.SaveChanges() > 0;
        }
    }
}
