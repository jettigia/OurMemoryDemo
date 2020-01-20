using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OurMemoryDb.Migrations
{
    public partial class CorrectMemoryFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "PostEntities",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PostEntities_UserId",
                table: "PostEntities",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostEntities_UserEntity_UserId",
                table: "PostEntities",
                column: "UserId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostEntities_UserEntity_UserId",
                table: "PostEntities");

            migrationBuilder.DropIndex(
                name: "IX_PostEntities_UserId",
                table: "PostEntities");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PostEntities");
        }
    }
}
