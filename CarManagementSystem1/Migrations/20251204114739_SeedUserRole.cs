using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarManagementSystem1.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "ba0a3673-8c2e-4e4c-948d-7a98744dfad0", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBOxjRfiY83A6EIBAvHUMRcDSRhMsaXUeZfDCKMRk+5p4gIJFUPJARaiqG+rj1LRkg==", null, false, "8bc388b8-69a5-4869-8da8-3ca55fa428f8", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9016), new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9043), new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9471), new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9477), new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9646), new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9652), new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9658), new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9662), new DateTime(2025, 12, 4, 19, 47, 37, 266, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 1, 59, 488, DateTimeKind.Local).AddTicks(9169), new DateTime(2025, 12, 3, 10, 1, 59, 488, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 1, 59, 488, DateTimeKind.Local).AddTicks(9198), new DateTime(2025, 12, 3, 10, 1, 59, 488, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 1, 59, 488, DateTimeKind.Local).AddTicks(9861), new DateTime(2025, 12, 3, 10, 1, 59, 488, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 1, 59, 488, DateTimeKind.Local).AddTicks(9872), new DateTime(2025, 12, 3, 10, 1, 59, 488, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 1, 59, 489, DateTimeKind.Local).AddTicks(102), new DateTime(2025, 12, 3, 10, 1, 59, 489, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 1, 59, 489, DateTimeKind.Local).AddTicks(110), new DateTime(2025, 12, 3, 10, 1, 59, 489, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 1, 59, 489, DateTimeKind.Local).AddTicks(117), new DateTime(2025, 12, 3, 10, 1, 59, 489, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 10, 1, 59, 489, DateTimeKind.Local).AddTicks(123), new DateTime(2025, 12, 3, 10, 1, 59, 489, DateTimeKind.Local).AddTicks(126) });
        }
    }
}
