using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "69cd9321-f952-48ab-93e1-0fa56e75943f", "User", "USER" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "214f9ee0-6c8c-4e2c-8c29-17c280189ee0", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 38, 50, 344, DateTimeKind.Local).AddTicks(1136), new DateTime(2022, 1, 24, 13, 38, 50, 346, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 38, 50, 346, DateTimeKind.Local).AddTicks(7964), new DateTime(2022, 1, 24, 13, 38, 50, 346, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 38, 50, 347, DateTimeKind.Local).AddTicks(9083), new DateTime(2022, 1, 24, 13, 38, 50, 347, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 38, 50, 347, DateTimeKind.Local).AddTicks(9354), new DateTime(2022, 1, 24, 13, 38, 50, 347, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 38, 50, 348, DateTimeKind.Local).AddTicks(2217), new DateTime(2022, 1, 24, 13, 38, 50, 348, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 38, 50, 348, DateTimeKind.Local).AddTicks(2445), new DateTime(2022, 1, 24, 13, 38, 50, 348, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 38, 50, 348, DateTimeKind.Local).AddTicks(2453), new DateTime(2022, 1, 24, 13, 38, 50, 348, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 38, 50, 348, DateTimeKind.Local).AddTicks(2458), new DateTime(2022, 1, 24, 13, 38, 50, 348, DateTimeKind.Local).AddTicks(2460) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 22, 0, 664, DateTimeKind.Local).AddTicks(7492), new DateTime(2022, 1, 24, 13, 22, 0, 667, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 22, 0, 667, DateTimeKind.Local).AddTicks(2895), new DateTime(2022, 1, 24, 13, 22, 0, 667, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(3409), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(3795), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6641), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6938), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6943), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6946) });
        }
    }
}
