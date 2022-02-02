using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

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
    }
}
