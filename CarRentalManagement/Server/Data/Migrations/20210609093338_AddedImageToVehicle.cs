using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12408b1c-e0ab-4dd8-ab99-d761b0f1cf31",
                column: "ConcurrencyStamp",
                value: "9cacb057-3893-4d90-83d7-c742f193ea79");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fd76e2a-6a76-4254-8de9-72718e7ffb51",
                column: "ConcurrencyStamp",
                value: "0069e8e3-6eea-4942-a2ce-ae40c1d92e3f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "161d7fad-fce9-48b4-a31b-369f56d0b1a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75d41065-e045-43bb-b887-478c4e6b5f42", "AQAAAAEAACcQAAAAELvNc94I8iAGV35giChgOWPHWEmzaQRASYpz5GTYFeneFi5f/PWyBH28wafW/JdkiQ==", "fa11d1d0-7148-41f8-b448-59c7ceab68e7" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 947, DateTimeKind.Local).AddTicks(7767), new DateTime(2021, 6, 9, 14, 3, 36, 953, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 953, DateTimeKind.Local).AddTicks(1177), new DateTime(2021, 6, 9, 14, 3, 36, 953, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 953, DateTimeKind.Local).AddTicks(1204), new DateTime(2021, 6, 9, 14, 3, 36, 953, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 953, DateTimeKind.Local).AddTicks(1214), new DateTime(2021, 6, 9, 14, 3, 36, 953, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4044), new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4097), new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4106), new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4116), new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4124), new DateTime(2021, 6, 9, 14, 3, 36, 955, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1111), new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1149), new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1159), new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1168), new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1177), new DateTime(2021, 6, 9, 14, 3, 36, 956, DateTimeKind.Local).AddTicks(1181) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12408b1c-e0ab-4dd8-ab99-d761b0f1cf31",
                column: "ConcurrencyStamp",
                value: "634cc649-f76a-4f3b-a915-9dbbfe0a0825");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fd76e2a-6a76-4254-8de9-72718e7ffb51",
                column: "ConcurrencyStamp",
                value: "1ca8457f-5d55-4521-977a-5e08d78ac29f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "161d7fad-fce9-48b4-a31b-369f56d0b1a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a602661-5b34-4fbd-9aa0-1bb498d9abed", "AQAAAAEAACcQAAAAEBvODNL7gwq48cPRDMoPgLXMvz4wLTtuEsCTfpSyyfk09nFq/lJkL5s7IrTBdB65PQ==", "baf79c64-5715-42bd-ab79-7fa16cf7fd4a" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 284, DateTimeKind.Local).AddTicks(1174), new DateTime(2021, 6, 5, 10, 1, 47, 289, DateTimeKind.Local).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 289, DateTimeKind.Local).AddTicks(1754), new DateTime(2021, 6, 5, 10, 1, 47, 289, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 289, DateTimeKind.Local).AddTicks(1780), new DateTime(2021, 6, 5, 10, 1, 47, 289, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 289, DateTimeKind.Local).AddTicks(1789), new DateTime(2021, 6, 5, 10, 1, 47, 289, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(4965), new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(5012), new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(5022), new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(5053), new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(5063), new DateTime(2021, 6, 5, 10, 1, 47, 291, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2405), new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2443), new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2453), new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2463), new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2472), new DateTime(2021, 6, 5, 10, 1, 47, 292, DateTimeKind.Local).AddTicks(2476) });
        }
    }
}
