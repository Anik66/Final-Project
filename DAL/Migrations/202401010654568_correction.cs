namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "DateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Patients", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "DOB", c => c.String(nullable: false));
            AlterColumn("dbo.Appointments", "DateTime", c => c.String(nullable: false));
        }
    }
}
