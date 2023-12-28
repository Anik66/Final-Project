namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOCTDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Uname = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 6),
                        Address = c.String(nullable: false, maxLength: 10),
                        Phonenumber = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.Uname);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doctors");
        }
    }
}
