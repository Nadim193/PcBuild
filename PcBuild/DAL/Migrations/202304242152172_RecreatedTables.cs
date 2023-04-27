namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecreatedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        uid = c.Int(nullable: false),
                        pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.pid, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.uid, cascadeDelete: true)
                .Index(t => t.uid)
                .Index(t => t.pid);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        uname = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 15),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        review = c.String(nullable: false),
                        date = c.DateTime(nullable: false),
                        uid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.uid, cascadeDelete: true)
                .Index(t => t.uid);
            
            CreateTable(
                "dbo.User_Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Oid = c.Int(nullable: false),
                        Uid = c.Int(nullable: false),
                        PaymentBy = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Oid, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Uid, cascadeDelete: true)
                .Index(t => t.Oid)
                .Index(t => t.Uid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Order", "Uid", "dbo.Users");
            DropForeignKey("dbo.User_Order", "Oid", "dbo.Orders");
            DropForeignKey("dbo.Reviews", "uid", "dbo.Users");
            DropForeignKey("dbo.Carts", "uid", "dbo.Users");
            DropForeignKey("dbo.Carts", "pid", "dbo.Products");
            DropIndex("dbo.User_Order", new[] { "Uid" });
            DropIndex("dbo.User_Order", new[] { "Oid" });
            DropIndex("dbo.Reviews", new[] { "uid" });
            DropIndex("dbo.Carts", new[] { "pid" });
            DropIndex("dbo.Carts", new[] { "uid" });
            DropTable("dbo.User_Order");
            DropTable("dbo.Reviews");
            DropTable("dbo.Users");
            DropTable("dbo.Carts");
        }
    }
}
