using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initiation3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_MyFlight_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Planes_PlaneId",
                table: "MyFlight");

            migrationBuilder.DropIndex(
                name: "IX_MyFlight_PlaneId",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "MyFlight");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "MyReservation");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersPassportNumber",
                table: "MyReservation",
                newName: "IX_MyReservation_PassengersPassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "MyFlight",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyReservation",
                table: "MyReservation",
                columns: new[] { "FlightsFlightId", "PassengersPassportNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_PlaneFK",
                table: "MyFlight",
                column: "PlaneFK");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Planes_PlaneFK",
                table: "MyFlight",
                column: "PlaneFK",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_MyReservation_MyFlight_FlightsFlightId",
                table: "MyReservation",
                column: "FlightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyReservation_Passengers_PassengersPassportNumber",
                table: "MyReservation",
                column: "PassengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Planes_PlaneFK",
                table: "MyFlight");

            migrationBuilder.DropForeignKey(
                name: "FK_MyReservation_MyFlight_FlightsFlightId",
                table: "MyReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_MyReservation_Passengers_PassengersPassportNumber",
                table: "MyReservation");

            migrationBuilder.DropIndex(
                name: "IX_MyFlight_PlaneFK",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyReservation",
                table: "MyReservation");

            migrationBuilder.RenameTable(
                name: "MyReservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameIndex(
                name: "IX_MyReservation_PassengersPassportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersPassportNumber");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "MyFlight",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "PassengersPassportNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_PlaneId",
                table: "MyFlight",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_MyFlight_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPassportNumber",
                table: "FlightPassenger",
                column: "PassengersPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Planes_PlaneId",
                table: "MyFlight",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
