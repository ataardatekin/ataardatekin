using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.DAL.Migrations
{
    public partial class seedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 18, 12, 8, 27, 639, DateTimeKind.Local).AddTicks(3785), new Guid("ebb66766-d17a-4591-9692-22b3a4816cb8") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 18, 12, 8, 27, 640, DateTimeKind.Local).AddTicks(6774), new Guid("c6b79c9b-b503-4521-b7dd-6f948dc3d782") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 18, 12, 8, 27, 640, DateTimeKind.Local).AddTicks(6784), new Guid("78ff2009-98ca-4f65-8bc2-43978d88d33a") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAdminUsername", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "UnitPrice", "UnitsInStock", "UpdatedAdminUsername", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, 1, null, null, new DateTime(2023, 5, 18, 12, 8, 27, 641, DateTimeKind.Local).AddTicks(5270), null, "İyi ayakkabı", null, true, new Guid("4fe79886-bd7f-45f5-8ef1-bbc72ff15778"), "Nike Airmax", 1, 5150m, (short)556, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, null, null, new DateTime(2023, 5, 18, 12, 8, 27, 641, DateTimeKind.Local).AddTicks(6007), null, "güzel", null, true, new Guid("bcd3480e-64d9-4d6b-b371-89fd48bad5d0"), "Iphone 14", 1, 51500m, (short)20, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 3, null, null, new DateTime(2023, 5, 18, 12, 8, 27, 641, DateTimeKind.Local).AddTicks(6011), null, "lezzetli", null, true, new Guid("be1480be-1d59-4d27-a5e2-8d6ecb8c298c"), "BigMac", 1, 51m, (short)5565, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 18, 12, 3, 14, 931, DateTimeKind.Local).AddTicks(3691), new Guid("d1c149b3-89c9-459f-9423-127708e15cf3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 18, 12, 3, 14, 945, DateTimeKind.Local).AddTicks(1608), new Guid("f1e2f0cd-5312-4c07-aaa7-40c76e435941") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterId" },
                values: new object[] { new DateTime(2023, 5, 18, 12, 3, 14, 945, DateTimeKind.Local).AddTicks(1621), new Guid("d82f1d3a-f2c6-4880-a2bd-9c92314c9626") });
        }
    }
}
