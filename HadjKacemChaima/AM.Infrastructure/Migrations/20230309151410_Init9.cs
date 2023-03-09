using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyReservation",
                table: "MyReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyFlight",
                table: "MyFlight");

            migrationBuilder.DropIndex(
                name: "IX_MyFlight_PlaneFK",
                table: "MyFlight");

            migrationBuilder.DropColumn(
                name: "EmployementDate",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Function",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "HealthInformation",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Passengers");

            migrationBuilder.RenameTable(
                name: "MyReservation",
                newName: "FlightPassenger");

            migrationBuilder.RenameTable(
                name: "MyFlight",
                newName: "Flights");

            migrationBuilder.RenameIndex(
                name: "IX_MyReservation_PassengersPassportNumber",
                table: "FlightPassenger",
                newName: "IX_FlightPassenger_PassengersPassportNumber");

            migrationBuilder.RenameColumn(
                name: "VilleDepart",
                table: "Flights",
                newName: "Departure");

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "Flights",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "Tunis");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "Flights",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger",
                columns: new[] { "FlightsFlightId", "PassengersPassportNumber" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "FlightId");

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    PassportNumber = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    EmployementDate = table.Column<DateTime>(type: "date", nullable: false),
                    Function = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Staffs_Passengers_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Travellers",
                columns: table => new
                {
                    PassportNumber = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    HealthInformation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travellers", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Travellers_Passengers_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_PlaneId",
                table: "Flights",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger",
                column: "FlightsFlightId",
                principalTable: "Flights",
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
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Flights_FlightsFlightId",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassenger_Passengers_PassengersPassportNumber",
                table: "FlightPassenger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Travellers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_PlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassenger",
                table: "FlightPassenger");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "Flights");

            migrationBuilder.RenameTable(
                name: "Flights",
                newName: "MyFlight");

            migrationBuilder.RenameTable(
                name: "FlightPassenger",
                newName: "MyReservation");

            migrationBuilder.RenameColumn(
                name: "Departure",
                table: "MyFlight",
                newName: "VilleDepart");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassenger_PassengersPassportNumber",
                table: "MyReservation",
                newName: "IX_MyReservation_PassengersPassportNumber");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployementDate",
                table: "Passengers",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Function",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthInformation",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Passengers",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "VilleDepart",
                table: "MyFlight",
                type: "nchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "Tunis",
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyFlight",
                table: "MyFlight",
                column: "FlightId");

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
    }
}
