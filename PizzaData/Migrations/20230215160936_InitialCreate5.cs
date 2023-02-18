using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Pizza",
                newName: "FlourName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FlourName",
                table: "Pizza",
                newName: "Name");
        }
    }
}
