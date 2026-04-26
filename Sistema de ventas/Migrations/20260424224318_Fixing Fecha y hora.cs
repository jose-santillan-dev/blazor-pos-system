using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyect.Migrations
{
    /// <inheritdoc />
    public partial class FixingFechayhora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "VentasDB");

            migrationBuilder.DropColumn(
                name: "Hora",
                table: "InventoryDB");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Hora",
                table: "VentasDB",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Hora",
                table: "InventoryDB",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
