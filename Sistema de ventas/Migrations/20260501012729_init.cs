using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyect.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    FechaCaducidad = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BasePrice = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProveedorsDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FechaRegisro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductosComprados = table.Column<double>(type: "REAL", nullable: false),
                    IngresosProveedor = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedorsDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VentasDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    FechaVenta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    precioVenta = table.Column<decimal>(type: "TEXT", nullable: false),
                    InventarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentasDB_InventoryDB_InventarioId",
                        column: x => x.InventarioId,
                        principalTable: "InventoryDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentasDB_InventarioId",
                table: "VentasDB",
                column: "InventarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProveedorsDB");

            migrationBuilder.DropTable(
                name: "VentasDB");

            migrationBuilder.DropTable(
                name: "InventoryDB");
        }
    }
}
