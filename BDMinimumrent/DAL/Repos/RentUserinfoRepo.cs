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
    internal class RentUserinfoRepo : Repo, IRepo<RentUserinfo, int, bool>
    {
        public bool Create(RentUserinfo obj)
        {
            object value = db.RentUserinfo.Add(obj);
            if (db.SaveChanges() > 0) return (bool)obj;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            object value = db.RentUserinfo.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<RentUserinfo> Read()
        {
            return db.RentUserinfo.ToList();
        }

        public RentUser info Read(int id)
        {
            return db.RentUserinfo.Find(id);
        }


        

        public bool Update(RentUserinfo obj)
        {
            var ex = Read(obj.Name);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public RentUserinfo Read(int obj)
        {
            throw new NotImplementedException();
        }
    }
}