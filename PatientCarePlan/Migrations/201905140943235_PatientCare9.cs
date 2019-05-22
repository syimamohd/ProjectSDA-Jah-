namespace PatientCarePlan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientCare9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Date = c.String(nullable: false, maxLength: 128),
                        Distance = c.String(),
                        Steps = c.String(),
                        Flights = c.String(),
                    })
                .PrimaryKey(t => t.Date);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Activities");
        }
    }
}
