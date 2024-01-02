using DAL.Interfaces;
using DAL.Interfaces.DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RentUserRepo : Repo, IRepo<RentUser, string, RentUser>
    {
        public RentUser Create(RentUser  obj)
        {
            db.RentUsers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.RentUsers.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<RentUser> Read()
        {
            return db.RentUsers.ToList();
        }

        public  RentUser Read(string id)
        {
            return db.RentUsers.Find(id);
        }

        public RentUser Update(RentUser obj)
        {
            var ex = Read(obj.Name);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}