using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bakery.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlavorTreats_AspNetUsers_UserId",
                table: "FlavorTreats");

            migrationBuilder.DropIndex(
                name: "IX_FlavorTreats_UserId",
                table: "FlavorTreats");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "FlavorTreats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "FlavorTreats",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FlavorTreats_UserId",
                table: "FlavorTreats",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlavorTreats_AspNetUsers_UserId",
                table: "FlavorTreats",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
