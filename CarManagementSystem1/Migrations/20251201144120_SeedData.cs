using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarManagementSystem1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8330), new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8350), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8356), new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8357), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8785), new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8786), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8791), new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8793), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8959), new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8960), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8965), new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8966), "X5", "System" },
                    { 3, "System", new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8970), new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8971), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8975), new DateTime(2025, 12, 1, 22, 41, 18, 109, DateTimeKind.Local).AddTicks(8976), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
