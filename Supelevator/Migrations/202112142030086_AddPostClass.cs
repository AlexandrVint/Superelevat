namespace Supelevator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FireLoadInfoes", "IsChanged", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FireLoadInfoes", "IsChanged");
        }
    }
}
