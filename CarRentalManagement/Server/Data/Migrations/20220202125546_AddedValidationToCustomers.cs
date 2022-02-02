using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationToCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3c90cf15-f139-480d-afc0-b03c655ce24b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "6b554e41-b978-471e-9ddf-05c50923c192");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec8470b9-c448-4198-9934-d1a4f8af35a6", "AQAAAAEAACcQAAAAEFyjg8WO+MLYhlDfZuusAFVHHIcovp/kIgxk3juLnmhG8jhcJujoewc1P/JiLCWGtA==", "0117f46d-9585-49f8-87fb-2ce449a468be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f55c8dd-f03d-47d3-83e8-4913e9e26dbf", "AQAAAAEAACcQAAAAEJH9FV+VqbbJJ/w8xxbINsKfdWDC/YyFNtvb7QCqczJFB6QkphhT6ZRoi/GkcOMOFA==", "8e4272cd-5ff8-4fb5-a979-6bc21095ab2f" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 55, 46, 32, DateTimeKind.Local).AddTicks(6975), new DateTime(2022, 2, 2, 13, 55, 46, 36, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 55, 46, 36, DateTimeKind.Local).AddTicks(9498), new DateTime(2022, 2, 2, 13, 55, 46, 36, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(1529), new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(1814), new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(4913), new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(5165), new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(5173), new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(5179), new DateTime(2022, 2, 2, 13, 55, 46, 38, DateTimeKind.Local).AddTicks(5182) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
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
                value: "9fd52d78-9a91-4584-9699-5dadc0b90a8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "4a2b6b9b-8457-4bb2-a2c2-d3bebd97e2c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f5470a2-d217-48f6-813b-f80dbd1e78bd", "AQAAAAEAACcQAAAAELxK+GdJ8W1n05ZrVdjZjudZEDCcgPLRLhxGk13F1ipkz81mXspGEczfczVLT2wgag==", "507e7863-f2ef-4c49-924c-4ed697254f86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "730f2a47-b3f2-4528-be60-86603fbd3174", "AQAAAAEAACcQAAAAENah8FlEyrgwugUpmcOclzmn0cGLiYUt4rQ4+gM4iDGxsaca3k+gfLQv7JKFhgWwgA==", "78a43cb8-cb50-4568-a871-8eedca762d61" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 6, 21, 579, DateTimeKind.Local).AddTicks(6716), new DateTime(2022, 2, 2, 13, 6, 21, 584, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 6, 21, 584, DateTimeKind.Local).AddTicks(1223), new DateTime(2022, 2, 2, 13, 6, 21, 584, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(2959), new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(3234), new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(6397), new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(6651), new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(6666), new DateTime(2022, 2, 2, 13, 6, 21, 585, DateTimeKind.Local).AddTicks(6668) });
        }
    }
}
