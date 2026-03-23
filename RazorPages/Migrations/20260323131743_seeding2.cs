using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPages.Migrations
{
    /// <inheritdoc />
    public partial class seeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d5db7f8-cd6e-44b8-a6f9-4c963128c807", "36306eda-44fa-41f4-beac-833b5f3f8823" });

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "36306eda-44fa-41f4-beac-833b5f3f8823");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5db7f8-cd6e-44b8-a6f9-4c963128c807");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a04dde26-8820-445e-b6dc-1e15d14617c1", "4a6edeca-e88d-4288-b50f-74f5880d1799", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7f8b4059-dd42-449f-9c09-a47664c02c0e", 0, "4f4b6fa2-0a0d-4b43-ac6f-1a3b2db0524c", "admin@admin.cz", false, false, null, "ADMIN@ADMIN.CZ", "ADMIN@ADMIN.CZ", "AQAAAAIAAYagAAAAEFo6h97AMWlii2B5cOoTkCsvhVH3LyRTg/RhAmO4DCHN/2KmwuUV1iGJ+JQcKwhgQg==", null, false, "117a31f6-93c1-4bb9-868b-6b89f95079e0", false, "admin@admin.cz" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a04dde26-8820-445e-b6dc-1e15d14617c1", "7f8b4059-dd42-449f-9c09-a47664c02c0e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a04dde26-8820-445e-b6dc-1e15d14617c1", "7f8b4059-dd42-449f-9c09-a47664c02c0e" });

            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "7f8b4059-dd42-449f-9c09-a47664c02c0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a04dde26-8820-445e-b6dc-1e15d14617c1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d5db7f8-cd6e-44b8-a6f9-4c963128c807", "53649917-bf11-4a7c-ae73-b0df619ff1ac", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "36306eda-44fa-41f4-beac-833b5f3f8823", 0, "95fd9b13-4e62-404b-a954-5bed0740a8df", "admin@test.cz", true, false, null, "ADMIN@TEST.CZ", "ADMIN@TEST.CZ", "AQAAAAIAAYagAAAAEAFhPrBD5FKYJ4V/3LJWcptfKFouctFKzpfwO+b03aTXORP1nXY8APubJ2MatDM9Iw==", null, false, "e267e74e-2c6c-4d4b-bdb7-f14eeeb91b08", false, "admin@test.cz" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3d5db7f8-cd6e-44b8-a6f9-4c963128c807", "36306eda-44fa-41f4-beac-833b5f3f8823" });
        }
    }
}
