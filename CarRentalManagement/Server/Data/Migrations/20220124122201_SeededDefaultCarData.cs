﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 24, 13, 22, 0, 664, DateTimeKind.Local).AddTicks(7492), new DateTime(2022, 1, 24, 13, 22, 0, 667, DateTimeKind.Local).AddTicks(2293), "Black", "System" },
                    { 2, "System", new DateTime(2022, 1, 24, 13, 22, 0, 667, DateTimeKind.Local).AddTicks(2895), new DateTime(2022, 1, 24, 13, 22, 0, 667, DateTimeKind.Local).AddTicks(2903), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(3409), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(3432), "Toyota", "System" },
                    { 2, "System", new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(3795), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(3800), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6641), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6653), "Prius", "System" },
                    { 2, "System", new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6935), "Vitz", "System" },
                    { 3, "System", new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6938), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6940), "3 Series", "System" },
                    { 4, "System", new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6943), new DateTime(2022, 1, 24, 13, 22, 0, 668, DateTimeKind.Local).AddTicks(6946), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
