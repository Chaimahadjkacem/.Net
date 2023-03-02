using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initiation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassportNumber = table.Column<int>(type: "int", maxLength: 7, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNumber = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: true),
                    EmployementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassportNumber);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaneType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "MyFlight",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VilleDepart = table.Column<string>(type: "nchar(100)", maxLength: 100, nullable: false, defaultValue: "Tunis"),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EffectiveArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedDuration = table.Column<int>(type: "int", nullable: false),
                    PlaneFK = table.Column<int>(type: "int", nullable: false),
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyFlight", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_MyFlight_Planes_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "Planes",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightPassenger",
                columns: table => new
                {
                    FlightsFlightId = table.Column<int>(type: "int", nullable: false),
                    PassengersPassportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassenger", x => new { x.FlightsFlightId, x.PassengersPassportNumber });
                    table.ForeignKey(
                        name: "FK_FlightPassenger_MyFlight_FlightsFlightId",
                        column: x => x.FlightsFlightId,
                        principalTable: "MyFlight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Passengers_PassengersPassportNumber",
                        column: x => x.PassengersPassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_PassengersPassportNumber",
                table: "FlightPassenger",
                column: "PassengersPassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_MyFlight_PlaneId",
                table: "MyFlight",
                column: "PlaneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPassenger");

            migrationBuilder.DropTable(
                name: "MyFlight");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
