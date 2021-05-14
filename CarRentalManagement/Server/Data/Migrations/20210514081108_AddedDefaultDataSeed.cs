using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12408b1c-e0ab-4dd8-ab99-d761b0f1cf31", "b06cec79-6403-4fbc-88fd-3da209e4afeb", "User", "USER" },
                    { "8fd76e2a-6a76-4254-8de9-72718e7ffb51", "a3a788b4-797e-4b29-b2f1-42f26e0db12f", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 14, 12, 41, 7, 570, DateTimeKind.Local).AddTicks(9509), new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(175), "Black", "System" },
                    { 2, "System", new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1336), new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1358), "Blue", "System" },
                    { 3, "System", new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1365), new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1370), "Red", "System" },
                    { 4, "System", new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1375), new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1379), "Golden", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2893), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2953), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2962), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2968), "FORD", "System" },
                    { 3, "System", new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2973), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2977), "FERRARI", "System" },
                    { 4, "System", new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2982), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2986), "TOYOTA", "System" },
                    { 5, "System", new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2990), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2994), "SAYPA", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2344), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2378), "A", "System" },
                    { 2, "System", new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2386), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2391), "B", "System" },
                    { 3, "System", new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2397), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2401), "C", "System" },
                    { 4, "System", new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2405), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2410), "D", "System" },
                    { 5, "System", new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2414), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2419), "E", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12408b1c-e0ab-4dd8-ab99-d761b0f1cf31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fd76e2a-6a76-4254-8de9-72718e7ffb51");

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
