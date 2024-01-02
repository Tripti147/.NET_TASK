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
    internal class RentUserreviewRepo : Repo, IRepo<RentUserreview, int, bool>
    {
        public bool Create(RentUserreview obj)
        {
            db.RentUserreviews.Add(obj);
            if (db.SaveChanges() > 0) return (bool)obj;
            return false;

        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.RentUserreviews.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<RentUserreview> Read(RentUserreview obj)
        {
            return db.RentUserreviews.ToList();
        }

        public RentUserreview Read(int id)
        {
            return db.RentUserreviews.Find(id);
        }

        public List<RentUserreview> Read()
        {
            throw new NotImplementedException();
        }

        public RentUserreview Update(RentUserreview obj)
        {
            var ex = Read(obj);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        bool IRepo<RentUserreview, int, bool>.Update(RentUserreview obj)
        {
            throw new NotImplementedException();
        }
    }
}