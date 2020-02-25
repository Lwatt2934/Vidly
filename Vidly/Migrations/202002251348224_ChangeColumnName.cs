namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(maxLength: 255));
            DropColumn("dbo.MembershipTypes", "MembershipTypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTypeName", c => c.String(maxLength: 255));
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
