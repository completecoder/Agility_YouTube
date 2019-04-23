namespace Agility.Data.SQLRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ApplicationName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DataModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SchemaId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DataProperties",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ModelId = c.String(),
                        SchemaPropertyId = c.String(),
                        Value = c.String(),
                        DataModel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DataModels", t => t.DataModel_Id)
                .Index(t => t.DataModel_Id);
            
            CreateTable(
                "dbo.SchemaProperties",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SchemaId = c.String(maxLength: 128),
                        Name = c.String(),
                        DisplayText = c.String(),
                        DataType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schemata", t => t.SchemaId)
                .Index(t => t.SchemaId);
            
            CreateTable(
                "dbo.Schemata",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ApplicationId = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SchemaProperties", "SchemaId", "dbo.Schemata");
            DropForeignKey("dbo.DataProperties", "DataModel_Id", "dbo.DataModels");
            DropIndex("dbo.SchemaProperties", new[] { "SchemaId" });
            DropIndex("dbo.DataProperties", new[] { "DataModel_Id" });
            DropTable("dbo.Schemata");
            DropTable("dbo.SchemaProperties");
            DropTable("dbo.DataProperties");
            DropTable("dbo.DataModels");
            DropTable("dbo.Applications");
        }
    }
}
