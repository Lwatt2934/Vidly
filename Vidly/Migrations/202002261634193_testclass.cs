namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testclass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.testclasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        aPropery = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.testclasses");
        }
    }
}
