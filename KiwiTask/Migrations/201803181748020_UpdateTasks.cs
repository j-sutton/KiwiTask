namespace KiwiTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTasks : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.KiwiTasks", "Owner_Id", "dbo.AspNetUsers");
            DropIndex("dbo.KiwiTasks", new[] { "Owner_Id" });
            RenameColumn(table: "dbo.KiwiTasks", name: "Owner_Id", newName: "OwnerId");
            AlterColumn("dbo.KiwiTasks", "OwnerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.KiwiTasks", "OwnerId");
            AddForeignKey("dbo.KiwiTasks", "OwnerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KiwiTasks", "OwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.KiwiTasks", new[] { "OwnerId" });
            AlterColumn("dbo.KiwiTasks", "OwnerId", c => c.String(maxLength: 128));
            RenameColumn(table: "dbo.KiwiTasks", name: "OwnerId", newName: "Owner_Id");
            CreateIndex("dbo.KiwiTasks", "Owner_Id");
            AddForeignKey("dbo.KiwiTasks", "Owner_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
