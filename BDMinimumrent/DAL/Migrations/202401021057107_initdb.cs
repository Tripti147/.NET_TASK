namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Adminhotelreviews", "hotelpostinfoid", "dbo.Adminhotelinfoes");
            DropForeignKey("dbo.Adminhotelreviews", "reviewinfo", "dbo.Adminhotelrents");
            DropForeignKey("dbo.Adminhotelinfoes", "Hotelpostinfo", "dbo.Adminhotelrents");
            DropIndex("dbo.Adminhotelinfoes", new[] { "Hotelpostinfo" });
            DropIndex("dbo.Adminhotelreviews", new[] { "reviewinfo" });
            DropIndex("dbo.Adminhotelreviews", new[] { "hotelpostinfoid" });
            CreateTable(
                "dbo.RentUserreviews",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userreview = c.String(nullable: false),
                        time = c.DateTime(nullable: false),
                        userreviewinfo = c.String(maxLength: 128),
                        userpostinfoid = c.Int(nullable: false),
                        userreviewdto = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.RentUsers", t => t.userreviewinfo)
                .ForeignKey("dbo.RentUserinfoes", t => t.userpostinfoid, cascadeDelete: true)
                .Index(t => t.userreviewinfo)
                .Index(t => t.userpostinfoid);
            
            CreateTable(
                "dbo.RentUsers",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.RentUserinfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        info = c.String(nullable: false),
                        userdescription = c.String(nullable: false),
                        userpostinfo = c.String(maxLength: 128),
                        Datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.RentUsers", t => t.userpostinfo)
                .Index(t => t.userpostinfo);
            
            DropTable("dbo.Adminhotelinfoes");
            DropTable("dbo.Adminhotelreviews");
            DropTable("dbo.Adminhotelrents");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Adminhotelrents",
                c => new
                    {
                        HotelName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 20),
                        Hoteltype = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.HotelName);
            
            CreateTable(
                "dbo.Adminhotelreviews",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        review = c.String(nullable: false),
                        time = c.DateTime(nullable: false),
                        reviewinfo = c.String(maxLength: 128),
                        hotelpostinfoid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Adminhotelinfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        info = c.String(nullable: false),
                        Hoteldescription = c.String(nullable: false),
                        Hotelpostinfo = c.String(maxLength: 128),
                        Datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropForeignKey("dbo.RentUserreviews", "userpostinfoid", "dbo.RentUserinfoes");
            DropForeignKey("dbo.RentUserinfoes", "userpostinfo", "dbo.RentUsers");
            DropForeignKey("dbo.RentUserreviews", "userreviewinfo", "dbo.RentUsers");
            DropIndex("dbo.RentUserinfoes", new[] { "userpostinfo" });
            DropIndex("dbo.RentUserreviews", new[] { "userpostinfoid" });
            DropIndex("dbo.RentUserreviews", new[] { "userreviewinfo" });
            DropTable("dbo.RentUserinfoes");
            DropTable("dbo.RentUsers");
            DropTable("dbo.RentUserreviews");
            CreateIndex("dbo.Adminhotelreviews", "hotelpostinfoid");
            CreateIndex("dbo.Adminhotelreviews", "reviewinfo");
            CreateIndex("dbo.Adminhotelinfoes", "Hotelpostinfo");
            AddForeignKey("dbo.Adminhotelinfoes", "Hotelpostinfo", "dbo.Adminhotelrents", "HotelName");
            AddForeignKey("dbo.Adminhotelreviews", "reviewinfo", "dbo.Adminhotelrents", "HotelName");
            AddForeignKey("dbo.Adminhotelreviews", "hotelpostinfoid", "dbo.Adminhotelinfoes", "id", cascadeDelete: true);
        }
    }
}
