namespace MyPract.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Team1Id = c.Int(nullable: false),
                        Team2Id = c.Int(nullable: false),
                        DateOfGame = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team1Id, cascadeDelete: true)
                .ForeignKey("dbo.SecondTeams", t => t.Team2Id, cascadeDelete: true)
                .Index(t => t.Team1Id)
                .Index(t => t.Team2Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SecondTeams",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Games", "Team2Id", "dbo.SecondTeams");
            DropForeignKey("dbo.SecondTeams", "Id", "dbo.Teams");
            DropForeignKey("dbo.Games", "Team1Id", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.SecondTeams", new[] { "Id" });
            DropIndex("dbo.Games", new[] { "Team2Id" });
            DropIndex("dbo.Games", new[] { "Team1Id" });
            DropTable("dbo.Players");
            DropTable("dbo.SecondTeams");
            DropTable("dbo.Teams");
            DropTable("dbo.Games");
        }
    }
}
