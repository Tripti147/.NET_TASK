namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.BDMinimumrentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.BDMinimumrentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            for (int i = 1; i <= 10; i++)
            {
                context.RentUsers.AddOrUpdate(new Models.RentUser
                {
                    UserName = "User" + i,
                    Name = "Customer" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, 10),
                    age = 22
                });
            }

            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                context.RentUserinfos.AddOrUpdate(new Models.RentUserinfo
                {
                    id = i,
                    info = Guid.NewGuid().ToString().Substring(0, 5),
                    userdescription = Guid.NewGuid().ToString(),
                    Datetime = DateTime.Now,
                    userpostinfo = "User-" + random.Next(1, 11),


                });
            }
            for (int i = 1; i <= 100; i++)
            {
                context.RentUsereviews.AddOrUpdate(new Models.RentUserreview
                {
                    id = i,
                    userreview = Guid.NewGuid().ToString().Substring(0, 5),
                    userpostinfoid = random.Next(1, 21),
                    time = DateTime.Now,
                    userreviewinfo = "User" + random.Next(1, 11),
                    userreviewdto = "Hotel" + i,

                });

            }

        }
    }
}
