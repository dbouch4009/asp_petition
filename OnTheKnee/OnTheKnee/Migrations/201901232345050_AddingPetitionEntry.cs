namespace OnTheKnee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPetitionEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Communities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CommunityName = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        EntryId = c.Guid(nullable: false),
                        PersonId = c.Guid(nullable: false),
                        EntryTime = c.DateTime(nullable: false),
                        GivenReasonId = c.Guid(nullable: false),
                        CommunityId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.EntryId);
            
            CreateTable(
                "dbo.GivenReasons",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GivenReasonDetail = c.String(maxLength: 3000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(maxLength: 255),
                        LastName = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.GivenReasons");
            DropTable("dbo.Entries");
            DropTable("dbo.Communities");
        }
    }
}
