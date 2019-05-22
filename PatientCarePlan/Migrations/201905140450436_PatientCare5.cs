namespace PatientCarePlan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientCare5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false));
        }
    }
}
