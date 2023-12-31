using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AppDetailRepo : Repo, IRepo<AppDetail, int, bool>
    {
        public bool Delete(int id)
        {
            var appdetail = Get(id);
            db.AppDetails.Remove(appdetail);
            return db.SaveChanges() > 0;
        }

        public List<AppDetail> Get()
        {
            return db.AppDetails.ToList();
        }

        public AppDetail Get(int id)
        {
            return db.AppDetails.Find(id);
        }

        public bool Insert(AppDetail obj)
        {
            db.AppDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(AppDetail obj)
        {
            var exorderdetails = Get(obj.Id);
            db.Entry(exorderdetails).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
