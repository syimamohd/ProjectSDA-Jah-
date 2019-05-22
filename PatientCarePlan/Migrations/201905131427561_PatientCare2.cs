namespace PatientCarePlan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientCare2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BodyMeasurements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Height = c.String(nullable: false),
                        Weight = c.String(nullable: false),
                        BodyFatPercent = c.String(nullable: false),
                        BodyMassIndex = c.String(nullable: false),
                        LeanBodyMass = c.String(nullable: false),
                        WaistCircumference = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BodyMeasurements");
        }
    }
}
