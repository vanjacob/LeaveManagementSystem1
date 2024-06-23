using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem1.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea6586a-5398-4651-bc04-1129f8d75593",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16f98127-cc0a-48bb-b80b-5a6147490072", new DateOnly(1998, 9, 14), "Default", "Admin", "AQAAAAIAAYagAAAAEO3WnTfhASr53YUsSQZbNyvyrnw6UsRtOk4CBFsuwiuQwfAK3V7RDEgyMG0neAKSgg==", "2ae2aea7-2a29-48f3-993e-85ba9b754b2a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ea6586a-5398-4651-bc04-1129f8d75593",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b8f3be6-5474-4968-a245-0c9a0c53baac", "AQAAAAIAAYagAAAAEGZQ86U06vTL8D+zsOqYT7avXMp0cU7UoSJ4XKS7ZMISS2P6Odix5E0LBPRI+u1wDA==", "1b113271-0470-4951-93c7-f9577c60f2bd" });
        }
    }
}
