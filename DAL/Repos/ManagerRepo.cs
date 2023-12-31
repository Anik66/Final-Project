using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManagerRepo : Repo, IRepo<Manager, string, bool>, IAuth<bool>
    {
        public bool Authenticate(string email, string password)
        {
            var data = db.Managers.FirstOrDefault(e => e.Email.Equals(email) && e.Password.Equals(password));
            return data != null;
        }
        public bool Delete(string email)
        {
            var mn = Get(email);
            db.Managers.Remove(mn);
            return db.SaveChanges() > 0;
        }
        public List<Manager> Get()
        {
            return db.Managers.ToList();
        }
        public Manager Get(string email)
        {
            return db.Managers.Find(email);
        }
        public bool Insert(Manager obj)
        {
            db.Managers.Add(obj);
            return db.SaveChanges() > 0;
        }
        public bool Update(Manager obj)
        {
            var exemp = Get(obj.Email);
            db.Entry(exemp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
