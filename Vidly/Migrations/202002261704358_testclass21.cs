namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testclass21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "testclass2_Id", "dbo.testclass2");
            DropIndex("dbo.Movies", new[] { "testclass2_Id" });
            DropColumn("dbo.Movies", "testclass2Id");
            DropColumn("dbo.Movies", "testclass2_Id");
            DropTable("dbo.testclass2");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.testclass2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "testclass2_Id", c => c.Int());
            AddColumn("dbo.Movies", "testclass2Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "testclass2_Id");
            AddForeignKey("dbo.Movies", "testclass2_Id", "dbo.testclass2", "Id");
        }
    }
}
