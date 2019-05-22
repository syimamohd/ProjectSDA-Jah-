namespace PatientCarePlan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientCare3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserId", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false));
            AddColumn("dbo.Users", "ReenterPassword", c => c.String(nullable: false));
            DropColumn("dbo.Users", "RetypeEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "RetypeEmail", c => c.String(nullable: false));
            DropColumn("dbo.Users", "ReenterPassword");
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "UserId");
        }
    }
}
