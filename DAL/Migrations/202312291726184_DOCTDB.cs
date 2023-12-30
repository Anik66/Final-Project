namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOCTDB : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Doctors");
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
            
            AddColumn("dbo.Doctors", "Age", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Doctors", "Gender", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Doctors", "BloodGroup", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.Doctors", "Email");
            DropColumn("dbo.Doctors", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Doctors");
            DropColumn("dbo.Doctors", "BloodGroup");
            DropColumn("dbo.Doctors", "Gender");
            DropColumn("dbo.Doctors", "Age");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
            AddPrimaryKey("dbo.Doctors", "Id");
        }
    }
}
