using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Flights_FlightId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passengers_PassengerPassportNumber",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_PassengerPassportNumber",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "PassengerPassportNumber",
                table: "Ticket");

            migrationBuilder.AlterColumn<double>(
                name: "Prix",
                table: "Ticket",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(2)",
                oldPrecision: 2,
                oldScale: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightFk",
                table: "Ticket",
                column: "FlightFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Flights_FlightFk",
                table: "Ticket",
                column: "FlightFk",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passengers_PassengerFk",
                table: "Ticket",
                column: "PassengerFk",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Flights_FlightFk",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passengers_PassengerFk",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_FlightFk",
                table: "Ticket");

            migrationBuilder.AlterColumn<double>(
                name: "Prix",
                table: "Ticket",
                type: "float(2)",
                precision: 2,
                scale: 3,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PassengerPassportNumber",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerPassportNumber",
                table: "Ticket",
                column: "PassengerPassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Flights_FlightId",
                table: "Ticket",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passengers_PassengerPassportNumber",
                table: "Ticket",
                column: "PassengerPassportNumber",
                principalTable: "Passengers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
