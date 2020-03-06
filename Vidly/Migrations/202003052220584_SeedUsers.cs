namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
               INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'042d8c30-bf10-4514-82dd-fe443c2243a0', N'guest@vidly.com', 0, N'AOj07TW1wQWSV3OSzqRz8RutqBrhmJtN3Y1cOKIs61OmhcwmYt5aRrYsWg2rPzVDKQ==', N'84552902-8fee-4b8a-90c2-a1daa5eda6c0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
               INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a923f1c5-c3ed-4906-98c2-64191cc24fee', N'admin@vidly.com', 0, N'AMv3mNgzTldhubgBc2CTTwi/MTaykvNGDTaCoOsoMaKYdDOdaZzLpvw6hercTXh3rw==', N'7bdd1372-c81d-416f-8c6b-6fe0accc9f16', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4a897804-a4c1-4121-9c10-3c5143bfb155', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a923f1c5-c3ed-4906-98c2-64191cc24fee', N'4a897804-a4c1-4121-9c10-3c5143bfb155')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
