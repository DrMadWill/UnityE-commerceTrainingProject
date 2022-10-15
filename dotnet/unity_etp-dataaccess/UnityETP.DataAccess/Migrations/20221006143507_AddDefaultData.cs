using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnityETP.DataAccess.Migrations
{
    public partial class AddDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreateAt", "IsDelete", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9813), false, "Baku", null },
                    { 2, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9816), false, "Washington", null },
                    { 3, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9817), false, "Ankara", null },
                    { 4, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9818), false, "London", null }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateAt", "IsDelete", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9788), false, "Azerbaijan", null },
                    { 2, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9790), false, "Turkey", null },
                    { 3, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9791), false, "United States", null },
                    { 4, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9792), false, "USA", null },
                    { 5, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9792), false, "Georgia", null },
                    { 6, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9793), false, "Italy", null },
                    { 7, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9794), false, "Germany", null },
                    { 8, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9795), false, "Ukraine", null }
                });

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "CreateAt", "IsDelete", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9835), false, "Yasamal", null },
                    { 2, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9837), false, "Ahamdli", null },
                    { 3, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9838), false, "Khatai", null }
                });

            migrationBuilder.InsertData(
                table: "UserOrderStatus",
                columns: new[] { "Id", "ColorId", "CreateAt", "IsDelete", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 27, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9856), false, "Sealed", null },
                    { 2, 21, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9857), false, "Buy", null },
                    { 3, 25, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9858), false, "Shipping", null },
                    { 4, 26, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9859), false, "Recovery", null }
                });

            migrationBuilder.InsertData(
                table: "VendorOrderStatus",
                columns: new[] { "Id", "ColorId", "CreateAt", "IsDelete", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 27, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9877), false, "Sealed", null },
                    { 2, 21, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9880), false, "Buy", null },
                    { 3, 25, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9881), false, "Shipping", null },
                    { 4, 26, new DateTime(2022, 10, 6, 18, 35, 6, 757, DateTimeKind.Local).AddTicks(9881), false, "Recovery", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserOrderStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserOrderStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserOrderStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserOrderStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VendorOrderStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VendorOrderStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VendorOrderStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VendorOrderStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5865));
        }
    }
}
