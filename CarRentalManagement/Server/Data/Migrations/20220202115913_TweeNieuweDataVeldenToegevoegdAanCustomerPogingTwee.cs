using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class TweeNieuweDataVeldenToegevoegdAanCustomerPogingTwee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "aae54cc9-2efe-4b87-b76b-aa86a50fdfc8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "daee131a-5a91-4d09-abab-aecd528b9988");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c21e873-d5f9-44bb-af0b-a5ce08ff5e19", "AQAAAAEAACcQAAAAEGXfN3R96CxQaOMsUNTnbRNcI+sz+vYKTMwXUUPZtImHQ7LR0L/mfFOS/rexe5AhuA==", "fd9452b1-e599-4719-8893-3807af886c59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ba8dced-75c4-46f3-8a98-9e754aef775a", "AQAAAAEAACcQAAAAEKlanDkSNLaHYTh664utVNzE78+YzEarlpa2MygkGwLDSHgmPax9vnAOwD5yvQ8ksA==", "3898758f-5be1-4608-a6f7-001b95016840" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 59, 12, 832, DateTimeKind.Local).AddTicks(3350), new DateTime(2022, 2, 2, 12, 59, 12, 835, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 59, 12, 835, DateTimeKind.Local).AddTicks(9438), new DateTime(2022, 2, 2, 12, 59, 12, 835, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 59, 12, 837, DateTimeKind.Local).AddTicks(5778), new DateTime(2022, 2, 2, 12, 59, 12, 837, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 59, 12, 837, DateTimeKind.Local).AddTicks(6183), new DateTime(2022, 2, 2, 12, 59, 12, 837, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 59, 12, 838, DateTimeKind.Local).AddTicks(597), new DateTime(2022, 2, 2, 12, 59, 12, 838, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 59, 12, 838, DateTimeKind.Local).AddTicks(1079), new DateTime(2022, 2, 2, 12, 59, 12, 838, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 59, 12, 838, DateTimeKind.Local).AddTicks(1096), new DateTime(2022, 2, 2, 12, 59, 12, 838, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 59, 12, 838, DateTimeKind.Local).AddTicks(1105), new DateTime(2022, 2, 2, 12, 59, 12, 838, DateTimeKind.Local).AddTicks(1109) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "03ed75d9-bba8-49e4-a5a8-a13848ae702f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "c85d62dc-e568-47e1-bf1a-d57b62b88602");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2820b86d-256b-4cd1-892f-7ed0945ef318", "AQAAAAEAACcQAAAAEOckUBk6eQu8fTrn5qBDj8ug9OMBYu7q5plMQL3axcsNAR8y/GAqjHv+wOb3NBFSrA==", "d895dad4-6a17-42ef-ab12-311bfaa2924c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2a50eec-7ab8-460c-b589-7d1015aa45f6", "AQAAAAEAACcQAAAAEJp60hUT8xcIfW2rBVIsGSIo3zN3SxxC3PmHUeIYuk75tTCHxx+rsxDTWYBfgR347Q==", "d3fbf2dd-13bf-4ed4-a0c3-6110f95a2398" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 31, 46, 349, DateTimeKind.Local).AddTicks(3471), new DateTime(2022, 2, 2, 12, 31, 46, 353, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 31, 46, 353, DateTimeKind.Local).AddTicks(4196), new DateTime(2022, 2, 2, 12, 31, 46, 353, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(739), new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(1227), new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(5710), new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(6076), new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(6089), new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(6097), new DateTime(2022, 2, 2, 12, 31, 46, 355, DateTimeKind.Local).AddTicks(6101) });
        }
    }
}
