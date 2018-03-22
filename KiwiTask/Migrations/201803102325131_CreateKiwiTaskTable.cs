namespace KiwiTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKiwiTaskTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KiwiTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaskDescription = c.String(),
                        DueDate = c.DateTime(),
                        AddDate = c.DateTime(nullable: false),
                        Owner_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Owner_Id)
                .Index(t => t.Owner_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KiwiTasks", "Owner_Id", "dbo.AspNetUsers");
            DropIndex("dbo.KiwiTasks", new[] { "Owner_Id" });
            DropTable("dbo.KiwiTasks");
        }
    }
}
