namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 15),
                        Uname = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 6),
                        Age = c.String(nullable: false, maxLength: 10),
                        Gender = c.String(nullable: false, maxLength: 10),
                        BloodGroup = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false, maxLength: 10),
                        Phonenumber = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                        DcEmail = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DcEmail, cascadeDelete: true)
                .Index(t => t.DcEmail);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", "DcEmail", "dbo.Doctors");
            DropIndex("dbo.Tokens", new[] { "DcEmail" });
            DropTable("dbo.Tokens");
            DropTable("dbo.Doctors");
        }
    }
}
