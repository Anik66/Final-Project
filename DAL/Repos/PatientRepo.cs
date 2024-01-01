using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PatientRepo : Repo, IRepo<Patient, string, bool>
    {
        public bool Authenticate(string email, string password)
        {
            var data = db.Patients.FirstOrDefault(e => e.Email.Equals(email) && e.Password.Equals(password));
            return data != null;
        }
        public bool Delete(string email)
        {
            var pt = Get(email);
            db.Patients.Remove(pt);
            return db.SaveChanges() > 0;
        }
        public List<Patient> Get()
        {
            return db.Patients.ToList();
        }
        public Patient Get(string email)
        {
            return db.Patients.Find(email);
        }
        public bool Insert(Patient obj)
        {
            db.Patients.Add(obj);
            return db.SaveChanges() > 0;
        }
        public bool Update(Patient obj)
        {
            var exemp = Get(obj.Email);
            db.Entry(exemp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
