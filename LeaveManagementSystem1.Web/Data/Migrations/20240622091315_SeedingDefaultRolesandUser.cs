using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem1.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52fe10d8-e6fd-4a20-b5f7-bbb50706460d", null, "Employee", "EMPLOYEE" },
                    { "d51444a6-984f-4d63-8d59-68106b8406a1", null, "Supervisor", "SUPERVISOR" },
                    { "f005f94a-063c-4b74-9138-8fba955c43eb", null, "Administrator", "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled",
                    "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed",
                    "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8ea6586a-5398-4651-bc04-1129f8d75593", 0, "6b8f3be6-5474-4968-a245-0c9a0c53baac",
                    "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", 
                    "AQAAAAIAAYagAAAAEGZQ86U06vTL8D+zsOqYT7avXMp0cU7UoSJ4XKS7ZMISS2P6Odix5E0LBPRI+u1wDA==", null, false, 
                    "1b113271-0470-4951-93c7-f9577c60f2bd", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f005f94a-063c-4b74-9138-8fba955c43eb", "8ea6586a-5398-4651-bc04-1129f8d75593" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52fe10d8-e6fd-4a20-b5f7-bbb50706460d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d51444a6-984f-4d63-8d59-68106b8406a1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f005f94a-063c-4b74-9138-8fba955c43eb", "8ea6586a-5398-4651-bc04-1129f8d75593" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f005f94a-063c-4b74-9138-8fba955c43eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea6586a-5398-4651-bc04-1129f8d75593");
        }
    }
}
