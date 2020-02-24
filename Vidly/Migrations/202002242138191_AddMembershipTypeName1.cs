namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeName1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipTypeName", c => c.String(maxLength: 255));


        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipTypeName", c => c.String());
        }
    }
}
