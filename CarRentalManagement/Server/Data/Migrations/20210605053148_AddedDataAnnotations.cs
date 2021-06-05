using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "161d7fad-fce9-48b4-a31b-369f56d0b1a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4d28e60-2a2c-4d47-bd5c-32a08e618ff2", "AQAAAAEAACcQAAAAEEqT9aYfXwKNXyejha49OeDxei70A2U2JMuqdPeKecExFuI0tImoiCdLVfGPxF3x4Q==", "f8c38939-8aff-45d2-8dbd-46c5f0e7cee6" });

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
        }
    }
}
