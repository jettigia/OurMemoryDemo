using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OurMemoryDb.Migrations
{
    public partial class InitialPostComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommentEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    PostId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentEntities_PostEntities_PostId",
                        column: x => x.PostId,
                        principalTable: "PostEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentEntities_PostId",
                table: "CommentEntities",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentEntities");

            migrationBuilder.DropTable(
                name: "PostEntities");
        }
    }
}
