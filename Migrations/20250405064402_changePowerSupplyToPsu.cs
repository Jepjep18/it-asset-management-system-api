using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITAM.Migrations
{
    /// <inheritdoc />
    public partial class changePowerSupplyToPsu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "power_supply",
                table: "computers",
                newName: "psu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "psu",
                table: "computers",
                newName: "power_supply");
        }
    }
}
