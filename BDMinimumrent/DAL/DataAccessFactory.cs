using DAL.Interfaces.DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<RentUserinfo, int, bool> RentUserinfoData()
        {
            return new RentUserinfoRepo();
        }
        public static IRepo<RentUserreview, int, bool> RentUserreviewData()
        {
            return new RentUserreviewRepo();
        }
        public static IRepo<RentUser, string, RentUser> RentUserData()
        {
            return new RentUserRepo();
        }
    }
}
