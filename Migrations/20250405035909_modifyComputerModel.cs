using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITAM.Migrations
{
    /// <inheritdoc />
    public partial class modifyComputerModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "casee",
                table: "computers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "power_supply",
                table: "computers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "processor",
                table: "computers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "casee",
                table: "computers");

            migrationBuilder.DropColumn(
                name: "power_supply",
                table: "computers");

            migrationBuilder.DropColumn(
                name: "processor",
                table: "computers");
        }
    }
}
