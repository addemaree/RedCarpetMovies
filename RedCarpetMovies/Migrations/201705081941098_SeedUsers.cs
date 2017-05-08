namespace RedCarpetMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'30679853-e1bd-419d-a368-dc12cbe57a2a', N'admin@rc.com', 0, N'ABmZ3E7SvF4Pas63E6CJdjPlRtB8JUwLyKSALZ5tuWU5cAWhU+0sL3HyGhZfora/eg==', N'a9677577-e7a2-44ec-ab17-28cb1dea3b2f', NULL, 0, 0, NULL, 1, 0, N'admin@rc.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'efa1b97c-3242-404b-973e-a89fb5d1917f', N'guest@rc.com', 0, N'AEi2FG/+XzFI3/UT43OCAHKTYhhXN8EgdBMD/ZzpLpLi/XKKL5pNfiK6xwXzzX8Q2Q==', N'c38a02d5-67c1-4de8-876e-f4f431a781ca', NULL, 0, 0, NULL, 1, 0, N'guest@rc.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bb9d5a2f-e1a3-44ad-8934-b9e0cb42d663', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'30679853-e1bd-419d-a368-dc12cbe57a2a', N'bb9d5a2f-e1a3-44ad-8934-b9e0cb42d663')
");
        }
        
        public override void Down()
        {
        }
    }
}
