namespace PatientCarePlan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientCare6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserId", c => c.String(nullable: false));
        }
    }
}
