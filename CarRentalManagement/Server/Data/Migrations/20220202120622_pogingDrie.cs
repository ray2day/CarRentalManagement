using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class pogingDrie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
