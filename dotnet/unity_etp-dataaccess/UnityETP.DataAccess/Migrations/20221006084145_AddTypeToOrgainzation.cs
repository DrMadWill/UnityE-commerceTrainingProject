using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnityETP.DataAccess.Migrations
{
    public partial class AddTypeToOrgainzation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Icons_Colors_ColorId",
                table: "Icons");

            migrationBuilder.DropIndex(
                name: "IX_Icons_ColorId",
                table: "Icons");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Icons");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationTypeId",
                table: "Organizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationTypesId",
                table: "Organizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OrganizationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationTypes_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_OrganizationTypesId",
                table: "Organizations",
                column: "OrganizationTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationTypes_ColorId",
                table: "OrganizationTypes",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_OrganizationTypes_OrganizationTypesId",
                table: "Organizations",
                column: "OrganizationTypesId",
                principalTable: "OrganizationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_OrganizationTypes_OrganizationTypesId",
                table: "Organizations");

            migrationBuilder.DropTable(
                name: "OrganizationTypes");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_OrganizationTypesId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "OrganizationTypeId",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "OrganizationTypesId",
                table: "Organizations");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Icons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Icons_ColorId",
                table: "Icons",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Icons_Colors_ColorId",
                table: "Icons",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
