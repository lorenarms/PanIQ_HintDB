using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PanIQ_HintDB.Data.Migrations
{
    public partial class DatabasePopulate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'009977f9-dd12-4851-a134-d8502c30e3f1', N'admin', N'ADMIN', N'admin@paniq.com', N'ADMIN@PANIQ.COM', 0, N'AQAAAAEAACcQAAAAEB9GhOgAewzDQso08Kr9x0+N7SxXs1KKTqACX1tDOCUdZBIDdlbYMvHIPWATHcm5LA==', N'Y6PT5PLC2EXFZN3IQ7TB5N4EIKQPSXDJ', N'64a52317-6966-46f8-82e5-c7e63fb4ea01', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f67eaa69-600c-4552-83c1-1e5f91b98fda', N'user', N'USER', N'user@paniq.com', N'USER@PANIQ.COM', 0, N'AQAAAAEAACcQAAAAEKSHlRxHdB6jMNDezqqu6p5qg+IXUfCDTOaUSBdEMRkPQf+bfQg7z7kmRgk5wWHlfA==', N'ESIXTSZLJCY7XSLDAVBW4O2X3B2L4DIG', N'bf96111f-5668-4643-86c1-ac0bc7cc6d31', NULL, 0, 0, NULL, 1, 0)
");
	        migrationBuilder.Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'b5f82673-17f4-4b9b-b92a-7f881ac63e46', N'user', N'USER', N'4b3ab4b2-9073-4974-a16e-8dd9ee310b8d')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd0f16cfc-f9d2-43a2-ad1c-b657362b3aaf', N'admin', N'ADMIN', N'd3a52ed8-e4cc-43dd-8e02-31b2134d95f8')
");
	        migrationBuilder.Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f67eaa69-600c-4552-83c1-1e5f91b98fda', N'b5f82673-17f4-4b9b-b92a-7f881ac63e46')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'009977f9-dd12-4851-a134-d8502c30e3f1', N'd0f16cfc-f9d2-43a2-ad1c-b657362b3aaf')
");
        }
	

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
