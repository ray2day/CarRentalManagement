using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "b3c78c00-bfdc-40d3-a144-9916e710a6b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "18427175-3f9e-4454-b6e6-7e4c08482b0e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb0a1552-a6ac-448b-bc92-79e9dfc65030", "AQAAAAEAACcQAAAAEHgduKjduF7vgLZqRuXhGmaDXX2/nes6O41W8v99PKIRfIirpMsBVEQXu+LeIxNClA==", "b487a764-7e20-4058-8e23-1226584afba2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9f15c2a-61c2-46c7-83a3-82dc4e87d152", "AQAAAAEAACcQAAAAEMEIrBwBlXuJGOXDCSJLrhQf4eGGCjmVixueRbrYn9KkkUuIt+gIqitGG+PMOXnpsA==", "98adefad-2ebf-4218-961e-81cce46a8810" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 9, 21, 35, 28, DateTimeKind.Local).AddTicks(4516), new DateTime(2022, 2, 2, 9, 21, 35, 32, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 9, 21, 35, 32, DateTimeKind.Local).AddTicks(8501), new DateTime(2022, 2, 2, 9, 21, 35, 32, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 9, 21, 35, 33, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 2, 2, 9, 21, 35, 33, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 9, 21, 35, 33, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 2, 2, 9, 21, 35, 33, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 9, 21, 35, 34, DateTimeKind.Local).AddTicks(2649), new DateTime(2022, 2, 2, 9, 21, 35, 34, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 9, 21, 35, 34, DateTimeKind.Local).AddTicks(2871), new DateTime(2022, 2, 2, 9, 21, 35, 34, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 9, 21, 35, 34, DateTimeKind.Local).AddTicks(2879), new DateTime(2022, 2, 2, 9, 21, 35, 34, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 2, 9, 21, 35, 34, DateTimeKind.Local).AddTicks(2884), new DateTime(2022, 2, 2, 9, 21, 35, 34, DateTimeKind.Local).AddTicks(2887) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "37188364-21e8-4b2a-9dc0-d2aaf862d373");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d2cc5bbc-7c42-4dec-bc51-132aea073da8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46638b81-37e9-43b1-a407-0a33d849a4a1", "AQAAAAEAACcQAAAAEDyxs80F7ePAvFv8D91jhZCas2q1b9qP58OnmCkVdPMihbpqHKCxc6fo5Z/THyMWjw==", "fbd2392c-bfc2-40b2-a189-876644df40eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9308f153-64e8-4728-8b19-c04aeb1d7951", "AQAAAAEAACcQAAAAEJcvra1vRQbgMHIIVKBpDC3yHNLIXTnMDNzHilMgcj/j3sIcRtmnXvWv9zqnhb439w==", "a7040b27-5377-403d-a706-f11bfca571e2" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 14, 45, 28, 914, DateTimeKind.Local).AddTicks(7757), new DateTime(2022, 1, 24, 14, 45, 28, 917, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 14, 45, 28, 917, DateTimeKind.Local).AddTicks(4191), new DateTime(2022, 1, 24, 14, 45, 28, 917, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(5008), new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(5265), new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(7985), new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(8211), new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(8219), new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(8224), new DateTime(2022, 1, 24, 14, 45, 28, 918, DateTimeKind.Local).AddTicks(8227) });
        }
    }
}
