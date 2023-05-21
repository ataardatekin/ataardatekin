using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    public partial class seedCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAdminUsername", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedAdminUsername", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[] { 1, "Giyim", null, null, new DateTime(2023, 5, 18, 12, 3, 14, 931, DateTimeKind.Local).AddTicks(3691), null, "adsadfsfd", true, new Guid("d1c149b3-89c9-459f-9423-127708e15cf3"), 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAdminUsername", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedAdminUsername", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[] { 2, "Teknoloji", null, null, new DateTime(2023, 5, 18, 12, 3, 14, 945, DateTimeKind.Local).AddTicks(1608), null, "adsadfsfd", true, new Guid("f1e2f0cd-5312-4c07-aaa7-40c76e435941"), 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedAdminUsername", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedAdminUsername", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[] { 3, "Yemek", null, null, new DateTime(2023, 5, 18, 12, 3, 14, 945, DateTimeKind.Local).AddTicks(1621), null, "adsadfsfd", true, new Guid("d82f1d3a-f2c6-4880-a2bd-9c92314c9626"), 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
