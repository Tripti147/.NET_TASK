using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class BDMinimumrentContext : DbContext
    {
        public DbSet<RentUser> RentUsers { get; set; }

        public DbSet<RentUserinfo> RentUserinfos { get; set; }

        public DbSet<RentUserreview> RentUsereviews { get; set; }
        public object RentUserreviews { get; internal set; }
        public object RentUserinfo { get; internal set; }
    }
}
