namespace PatientCarePlan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PatientCare1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nutritions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Caffeine = c.String(nullable: false),
                        Calcium = c.String(nullable: false),
                        Carbohydrates = c.String(nullable: false),
                        Fibre = c.String(nullable: false),
                        Protein = c.String(nullable: false),
                        SaturatedFat = c.String(nullable: false),
                        Water = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nutritions");
        }
    }
}
