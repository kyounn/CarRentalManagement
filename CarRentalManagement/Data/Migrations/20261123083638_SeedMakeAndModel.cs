using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedMakeAndModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Model",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Model",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Make",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Make",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Colour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Colour",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Black", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Blue", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2026, 11, 23, 16, 36, 38, 188, DateTimeKind.Local).AddTicks(7866), new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(1117), "BMW", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(1586), new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(1588), "Toyota", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy", "updatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(5187), new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(5578), "i4", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(5943), new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(5945), "X5", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(5948), new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(5948), "Prius", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(5949), new DateTime(2026, 11, 23, 16, 36, 38, 190, DateTimeKind.Local).AddTicks(5950), "C-HR", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Make");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Make");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Colour");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Colour");
        }
    }
}
