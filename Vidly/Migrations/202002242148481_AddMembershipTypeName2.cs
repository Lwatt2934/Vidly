﻿namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddMembershipTypeName2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.MembershipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE dbo.MembershipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE dbo.MembershipTypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE dbo.MembershipTypes SET Name = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
