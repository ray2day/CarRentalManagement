using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
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
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "86030bba-54df-491f-8f8e-d29bcbdc0ce7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "8901f62b-de3c-4512-9e74-4af370e47a0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fae1b85-1f05-410d-99a8-cca884dd32e2", "AQAAAAEAACcQAAAAEJ0x7Ncl8/e/Xwbu/opxEGWjPzocDstDEjqFVoqBb0by6y0i/bfhBx2RdPnmomJnyQ==", "d033a93a-f3bd-43f9-888a-4f36e464e2cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af9cd03d-341f-4faa-97bd-3385c6d6d1d6", "AQAAAAEAACcQAAAAEKG3vbVmOUMvKE8+DcgBumpOYlG2EkFlMS03UH59RoQltAp45wPLNc0ohoZ6jJbCvg==", "742bc644-22bc-41c6-83b4-e186c20c8aba" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 18, 14, 9, 951, DateTimeKind.Local).AddTicks(6228), new DateTime(2022, 2, 4, 18, 14, 9, 956, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 18, 14, 9, 956, DateTimeKind.Local).AddTicks(3076), new DateTime(2022, 2, 4, 18, 14, 9, 956, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(4094), new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(4338), new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(7497), new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(7506), new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(7511), new DateTime(2022, 2, 4, 18, 14, 9, 957, DateTimeKind.Local).AddTicks(7513) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

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
    }
}
