using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem1.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "days",
                table: "LeaveAllocations",
                newName: "Days");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1059ada4-3252-4c14-b00f-bf32c73ea482", null, "Administrator", "Administrator" },
                    { "41860a17-9ca8-4ad9-bad0-f6a2e8e8dc59", null, "Employee", "EMPLOYEE" },
                    { "94ed9338-1062-40b4-8667-2f622a1f789a", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "17eca5b4-47ac-47b5-8e87-b7325ce0daf1", 0, "8b9f737b-3bca-4823-aedd-3a2bf9a19252", new DateOnly(1998, 9, 14), "admin@localhost.com", true, "Default", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEO+xZwLuhT8cXOOxqgKT/v/NSWW8zRZ+AxD6jUh93RXphut3xGrjkwnXBu0LuJxZEw==", null, false, "822fa54b-027f-4722-9ea4-55cb3312889b", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1059ada4-3252-4c14-b00f-bf32c73ea482", "17eca5b4-47ac-47b5-8e87-b7325ce0daf1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41860a17-9ca8-4ad9-bad0-f6a2e8e8dc59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94ed9338-1062-40b4-8667-2f622a1f789a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1059ada4-3252-4c14-b00f-bf32c73ea482", "17eca5b4-47ac-47b5-8e87-b7325ce0daf1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1059ada4-3252-4c14-b00f-bf32c73ea482");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17eca5b4-47ac-47b5-8e87-b7325ce0daf1");

            migrationBuilder.RenameColumn(
                name: "Days",
                table: "LeaveAllocations",
                newName: "days");

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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8ea6586a-5398-4651-bc04-1129f8d75593", 0, "10755d75-044a-4e21-8a19-4e16d3a1f3b8", new DateOnly(1998, 9, 14), "admin@localhost.com", true, "Default", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIW3EITI3mDbaCKRMyvCNMQun9MrIxQparOQP/l7Oxw3nHJkIykoexEUwDXgttceSQ==", null, false, "39931d65-bac1-449a-9287-242fb1b8e6a7", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f005f94a-063c-4b74-9138-8fba955c43eb", "8ea6586a-5398-4651-bc04-1129f8d75593" });
        }
    }
}
