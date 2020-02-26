namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testclass1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.testclasses");
        }
        
        public override void Down()
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
    }
}
