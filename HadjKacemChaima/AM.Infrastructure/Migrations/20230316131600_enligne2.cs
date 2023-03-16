using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class enligne2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_PlaneId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "Flights");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_PlaneFK",
                table: "Flights",
                column: "PlaneFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneFK",
                table: "Flights",
                column: "PlaneFK",
                principalTable: "Planes",
                principalColumn: "PlaneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneFK",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_PlaneFK",
                table: "Flights");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "Flights",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_PlaneId",
                table: "Flights",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId");
        }
    }
}
