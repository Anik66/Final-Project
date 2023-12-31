using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class FeeRepo : Repo, IRepo<Fee, int, bool>
    {
        public bool Delete(int id)
        {
            var fee = Get(id);
            db.Fees.Remove(fee);
            return db.SaveChanges() > 0;
        }
        public List<Fee> Get()
        {
            return db.Fees.ToList();
        }
        public Fee Get(int id)
        {
            return db.Fees.Find(id);
        }
        public bool Insert(Fee obj)
        {
            db.Fees.Add(obj);
            return db.SaveChanges() > 0;
        }
        public bool Update(Fee obj)
        {
            var exemp = Get(obj.Id);
            db.Entry(exemp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
