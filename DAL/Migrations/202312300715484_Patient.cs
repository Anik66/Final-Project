namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Patient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dr_Name = c.String(nullable: false),
                        Specialist = c.String(nullable: false),
                        DateTime = c.String(nullable: false),
                        Chember_Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.Patients",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Email = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false),
                        DOB = c.String(nullable: false),
                        Blood_Gloup = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
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
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
