using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnityETP.DataAccess.Migrations
{
    public partial class AddDefaultColorIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Code", "CreateAt", "IsDelete", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "fff", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5559), false, "White", null },
                    { 2, "f8f9fa", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5561), false, "Gray-100", null },
                    { 3, "e9ecef", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5563), false, "Gray-200", null },
                    { 4, "dee2e6", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5565), false, "Gray-300", null },
                    { 5, "cfdbe6", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5566), false, "Gray-400", null },
                    { 6, "adb5bd", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5568), false, "Gray-500", null },
                    { 7, "6c757d", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5569), false, "Gray-600", null },
                    { 8, "383e50", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5571), false, "Gray-700", null },
                    { 9, "2f3446", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5572), false, "Gray-800", null },
                    { 10, "1e2231", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5574), false, "Gray-900", null },
                    { 11, "000", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5575), false, "Black", null },
                    { 12, "4f5d77", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5577), false, "Body", null },
                    { 13, "495057", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5578), false, "Heading", null },
                    { 14, "292f46", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5579), false, "Menu", null },
                    { 15, "f7f8f9", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5590), false, "Bg-grey", null },
                    { 16, "4d5368", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5605), false, "Ligth", null },
                    { 17, "222736", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5606), false, "Dark-Body", null },
                    { 18, "3BB77E", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5608), false, "Brand", null },
                    { 19, "29A56C", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5609), false, "Brand-Dark", null },
                    { 20, "5897fb", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5611), false, "Blue", null },
                    { 21, "782cf1", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5612), false, "indigo", null },
                    { 22, "7850c2", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5614), false, "purple", null },
                    { 23, "d63384", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5615), false, "pink", null },
                    { 24, "ff3551", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5616), false, "red", null },
                    { 25, "fd8a14", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5623), false, "orange", null },
                    { 26, "ffb300", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5624), false, "yellow", null },
                    { 27, "3ed092", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5626), false, "green", null },
                    { 28, "19b989", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5627), false, "teal", null },
                    { 29, "18a1b7", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5628), false, "cyan", null }
                });

            migrationBuilder.InsertData(
                table: "Icons",
                columns: new[] { "Id", "Code", "CreateAt", "IsDelete", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "md-qr_code", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5852), false, "Orders", null },
                    { 2, "md-shopping_bag", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5855), false, "Products", null },
                    { 3, "md-shopping_cart", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5856), false, "Orders-2", null },
                    { 4, "md-store", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5857), false, "Sellers", null },
                    { 5, "md-add_box", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5858), false, "Add", null },
                    { 6, "md-monetization_on", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5859), false, "Transactions", null },
                    { 7, "md-person", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5860), false, "Preson", null },
                    { 8, "md-comment", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5861), false, "Reviews", null },
                    { 9, "md-stars", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5862), false, "Brands", null },
                    { 10, "md-pie_chart", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5863), false, "Chart", null },
                    { 11, "md-local_offer", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5864), false, "Tag", null },
                    { 12, "md-settings", new DateTime(2022, 10, 6, 18, 34, 30, 667, DateTimeKind.Local).AddTicks(5865), false, "Setting", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
