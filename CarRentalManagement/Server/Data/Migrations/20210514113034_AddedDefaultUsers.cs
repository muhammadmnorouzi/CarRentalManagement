using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12408b1c-e0ab-4dd8-ab99-d761b0f1cf31",
                column: "ConcurrencyStamp",
                value: "fbe82099-1bfc-4c2d-8715-34f6ce8f6f0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fd76e2a-6a76-4254-8de9-72718e7ffb51",
                column: "ConcurrencyStamp",
                value: "88d3b280-2cbb-4cac-b146-2d10afe9f56b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "161d7fad-fce9-48b4-a31b-369f56d0b1a5", 0, "d4d28e60-2a2c-4d47-bd5c-32a08e618ff2", "muhammadmnorouzi@outlook.com", false, "Admin", "User", false, null, "MUHAMMADMNOROUZI@OUTLOOK.COM", "ADMIN", "AQAAAAEAACcQAAAAEEqT9aYfXwKNXyejha49OeDxei70A2U2JMuqdPeKecExFuI0tImoiCdLVfGPxF3x4Q==", null, false, "f8c38939-8aff-45d2-8dbd-46c5f0e7cee6", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 228, DateTimeKind.Local).AddTicks(9021), new DateTime(2021, 5, 14, 16, 0, 33, 233, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 234, DateTimeKind.Local).AddTicks(431), new DateTime(2021, 5, 14, 16, 0, 33, 234, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 234, DateTimeKind.Local).AddTicks(460), new DateTime(2021, 5, 14, 16, 0, 33, 234, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 234, DateTimeKind.Local).AddTicks(470), new DateTime(2021, 5, 14, 16, 0, 33, 234, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3887), new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3960), new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3970), new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3980), new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3989), new DateTime(2021, 5, 14, 16, 0, 33, 237, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5812), new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5862), new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5872), new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5881), new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5891), new DateTime(2021, 5, 14, 16, 0, 33, 238, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8fd76e2a-6a76-4254-8de9-72718e7ffb51", "161d7fad-fce9-48b4-a31b-369f56d0b1a5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8fd76e2a-6a76-4254-8de9-72718e7ffb51", "161d7fad-fce9-48b4-a31b-369f56d0b1a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "161d7fad-fce9-48b4-a31b-369f56d0b1a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12408b1c-e0ab-4dd8-ab99-d761b0f1cf31",
                column: "ConcurrencyStamp",
                value: "b06cec79-6403-4fbc-88fd-3da209e4afeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fd76e2a-6a76-4254-8de9-72718e7ffb51",
                column: "ConcurrencyStamp",
                value: "a3a788b4-797e-4b29-b2f1-42f26e0db12f");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 570, DateTimeKind.Local).AddTicks(9509), new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1336), new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1365), new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1375), new DateTime(2021, 5, 14, 12, 41, 7, 576, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2893), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2962), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2973), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2982), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2990), new DateTime(2021, 5, 14, 12, 41, 7, 579, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2344), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2386), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2397), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2405), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2414), new DateTime(2021, 5, 14, 12, 41, 7, 580, DateTimeKind.Local).AddTicks(2419) });
        }
    }
}
