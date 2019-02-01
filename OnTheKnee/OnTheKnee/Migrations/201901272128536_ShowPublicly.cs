namespace OnTheKnee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShowPublicly : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "ShowPublicly", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "ShowPublicly");
        }
    }
}
