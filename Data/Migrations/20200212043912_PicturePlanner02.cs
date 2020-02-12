using Microsoft.EntityFrameworkCore.Migrations;

namespace PicturePlannerIDF.Data.Migrations
{
    public partial class PicturePlanner02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Plans_FloorId",
                table: "Plans",
                column: "FloorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_Things_FloorId",
                table: "Plans",
                column: "FloorId",
                principalTable: "Things",
                principalColumn: "ThingId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plans_Things_FloorId",
                table: "Plans");

            migrationBuilder.DropIndex(
                name: "IX_Plans_FloorId",
                table: "Plans");
        }
    }
}
