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
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "37188364-21e8-4b2a-9dc0-d2aaf862d373");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d2cc5bbc-7c42-4dec-bc51-132aea073da8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "46638b81-37e9-43b1-a407-0a33d849a4a1", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDyxs80F7ePAvFv8D91jhZCas2q1b9qP58OnmCkVdPMihbpqHKCxc6fo5Z/THyMWjw==", null, false, "fbd2392c-bfc2-40b2-a189-876644df40eb", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "9308f153-64e8-4728-8b19-c04aeb1d7951", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJcvra1vRQbgMHIIVKBpDC3yHNLIXTnMDNzHilMgcj/j3sIcRtmnXvWv9zqnhb439w==", null, false, "a7040b27-5377-403d-a706-f11bfca571e2", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "69cd9321-f952-48ab-93e1-0fa56e75943f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "214f9ee0-6c8c-4e2c-8c29-17c280189ee0");

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
    }
}
