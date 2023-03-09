using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Prix",
                table: "Ticket",
                type: "float(2)",
                precision: 2,
                scale: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Prix",
                table: "Ticket",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(2)",
                oldPrecision: 2,
                oldScale: 3);
        }
    }
}
