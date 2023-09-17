using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccess.Migrations
{
    public partial class UpdateWorkLocationColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationID",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "WorkLocationID",
                table: "AspNetUsers",
                newName: "WorkLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_WorkLocationID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_WorkLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationId",
                table: "AspNetUsers",
                column: "WorkLocationId",
                principalTable: "WorkLocations",
                principalColumn: "WorkLocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "WorkLocationId",
                table: "AspNetUsers",
                newName: "WorkLocationID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_WorkLocationId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_WorkLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationID",
                table: "AspNetUsers",
                column: "WorkLocationID",
                principalTable: "WorkLocations",
                principalColumn: "WorkLocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
