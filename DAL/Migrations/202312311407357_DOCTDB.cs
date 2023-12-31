namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class DOCTDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tokens", "DcEmail", "dbo.Doctors");
            DropIndex("dbo.Tokens", new[] { "DcEmail" });
            DropPrimaryKey("dbo.Patients");
            CreateTable(
                "dbo.AppDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoctorFees = c.Double(nullable: false),
                        AppId = c.Int(nullable: false),
                        DcMail = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Appointments", t => t.AppId, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.DcMail, cascadeDelete: true)
                .Index(t => t.AppId)
                .Index(t => t.DcMail);
            
            CreateTable(
                "dbo.Fees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Paid = c.Double(nullable: false),
                        PaymentDate = c.DateTime(nullable: false),
                        PId = c.Int(nullable: false),
                        AId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Appointments", t => t.AId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PId, cascadeDelete: true)
                .Index(t => t.PId)
                .Index(t => t.AId);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false, maxLength: 10),
                        Phonenumber = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.Email);
            
            AddColumn("dbo.Appointments", "Fee", c => c.String(nullable: false));
            AddColumn("dbo.Appointments", "Status", c => c.String());
            AddColumn("dbo.Appointments", "MngMail", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Patients", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Patients", "Balance", c => c.Double(nullable: false));
            AddColumn("dbo.Tokens", "MngMail", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Patients", "Name", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Patients", "Id");
            CreateIndex("dbo.Appointments", "MngMail");
            CreateIndex("dbo.Tokens", "MngMail");
            AddForeignKey("dbo.Appointments", "MngMail", "dbo.Managers", "Email", cascadeDelete: true);
            AddForeignKey("dbo.Tokens", "MngMail", "dbo.Managers", "Email", cascadeDelete: true);
            DropColumn("dbo.Tokens", "DcEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tokens", "DcEmail", c => c.String(nullable: false, maxLength: 15));
            DropForeignKey("dbo.Tokens", "MngMail", "dbo.Managers");
            DropForeignKey("dbo.AppDetails", "DcMail", "dbo.Doctors");
            DropForeignKey("dbo.AppDetails", "AppId", "dbo.Appointments");
            DropForeignKey("dbo.Appointments", "MngMail", "dbo.Managers");
            DropForeignKey("dbo.Fees", "PId", "dbo.Patients");
            DropForeignKey("dbo.Fees", "AId", "dbo.Appointments");
            DropIndex("dbo.Tokens", new[] { "MngMail" });
            DropIndex("dbo.Fees", new[] { "AId" });
            DropIndex("dbo.Fees", new[] { "PId" });
            DropIndex("dbo.Appointments", new[] { "MngMail" });
            DropIndex("dbo.AppDetails", new[] { "DcMail" });
            DropIndex("dbo.AppDetails", new[] { "AppId" });
            DropPrimaryKey("dbo.Patients");
            AlterColumn("dbo.Patients", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Tokens", "MngMail");
            DropColumn("dbo.Patients", "Balance");
            DropColumn("dbo.Patients", "Id");
            DropColumn("dbo.Appointments", "MngMail");
            DropColumn("dbo.Appointments", "Status");
            DropColumn("dbo.Appointments", "Fee");
            DropTable("dbo.Managers");
            DropTable("dbo.Fees");
            DropTable("dbo.AppDetails");
            AddPrimaryKey("dbo.Patients", "Name");
            CreateIndex("dbo.Tokens", "DcEmail");
            AddForeignKey("dbo.Tokens", "DcEmail", "dbo.Doctors", "Email", cascadeDelete: true);
        }
    }
}
