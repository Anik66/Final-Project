using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DoctorRepo : Repo, IRepo<Doctor, string, bool>, IAuth<bool>
    {
        public bool Authenticate(string email, string password)
        {
            var data = db.Doctors.FirstOrDefault(e => e.Email.Equals(email) && e.Password.Equals(password));
            return data != null;
        }
        public bool Delete(string email)
        {
            var dc = Get(email);
            db.Doctors.Remove(dc);
            return db.SaveChanges() > 0;
        }
        public List<Doctor> Get()
        {
            return db.Doctors.ToList();
        }
        public Doctor Get(string email)
        {
            return db.Doctors.Find(email);
        }
        public bool Insert(Doctor obj)
        {
            db.Doctors.Add(obj);
            return db.SaveChanges() > 0;
        }
        public bool Update(Doctor obj)
        {
            var exemp = Get(obj.Email);
            db.Entry(exemp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
