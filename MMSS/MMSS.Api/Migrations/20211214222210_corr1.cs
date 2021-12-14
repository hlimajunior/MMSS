using Microsoft.EntityFrameworkCore.Migrations;

namespace MMSS.Api.Migrations
{
    public partial class corr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlatformsShows_Platforms_PlatformId1",
                table: "PlatformsShows");

            migrationBuilder.DropIndex(
                name: "IX_PlatformsShows_PlatformId1",
                table: "PlatformsShows");

            migrationBuilder.DropColumn(
                name: "PlatformId1",
                table: "PlatformsShows");

            migrationBuilder.AlterColumn<int>(
                name: "PlatformId",
                table: "PlatformsShows",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_PlatformsShows_Platforms_PlatformId",
                table: "PlatformsShows",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlatformsShows_Platforms_PlatformId",
                table: "PlatformsShows");

            migrationBuilder.AlterColumn<string>(
                name: "PlatformId",
                table: "PlatformsShows",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "PlatformId1",
                table: "PlatformsShows",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlatformsShows_PlatformId1",
                table: "PlatformsShows",
                column: "PlatformId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PlatformsShows_Platforms_PlatformId1",
                table: "PlatformsShows",
                column: "PlatformId1",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
