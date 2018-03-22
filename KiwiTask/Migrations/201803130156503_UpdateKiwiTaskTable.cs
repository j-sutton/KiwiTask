namespace KiwiTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateKiwiTaskTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KiwiTasks", "Name", c => c.String());
            AddColumn("dbo.KiwiTasks", "Description", c => c.String());
            DropColumn("dbo.KiwiTasks", "TaskDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KiwiTasks", "TaskDescription", c => c.String());
            DropColumn("dbo.KiwiTasks", "Description");
            DropColumn("dbo.KiwiTasks", "Name");
        }
    }
}
