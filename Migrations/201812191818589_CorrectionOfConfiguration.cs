namespace OilTeamProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectionOfConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Performances", "EvaluationID", "dbo.Evaluations");
            AddForeignKey("dbo.Performances", "EvaluationID", "dbo.Evaluations", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Performances", "EvaluationID", "dbo.Evaluations");
            AddForeignKey("dbo.Performances", "EvaluationID", "dbo.Evaluations", "ID");
        }
    }
}
