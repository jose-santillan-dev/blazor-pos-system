using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyect.Migrations
{
    /// <inheritdoc />
    public partial class typedecimaltoBasePrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "BasePrice",
                table: "InventoryDB",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "BasePrice",
                table: "InventoryDB",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }
    }
}
