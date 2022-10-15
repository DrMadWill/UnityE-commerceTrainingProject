using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnityETP.DataAccess.Migrations
{
    public partial class IconColorProblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ShippingStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Options",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "OnlineAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShippingStatuses_ColorId",
                table: "ShippingStatuses",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_ColorId",
                table: "Options",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineAddresses_ColorId",
                table: "OnlineAddresses",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineAddresses_Colors_ColorId",
                table: "OnlineAddresses",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Colors_ColorId",
                table: "Options",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingStatuses_Colors_ColorId",
                table: "ShippingStatuses",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OnlineAddresses_Colors_ColorId",
                table: "OnlineAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Options_Colors_ColorId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingStatuses_Colors_ColorId",
                table: "ShippingStatuses");

            migrationBuilder.DropIndex(
                name: "IX_ShippingStatuses_ColorId",
                table: "ShippingStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Options_ColorId",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_OnlineAddresses_ColorId",
                table: "OnlineAddresses");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ShippingStatuses");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "OnlineAddresses");
        }
    }
}
