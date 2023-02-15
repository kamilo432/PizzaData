using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "Flours",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flours_PizzaId",
                table: "Flours",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flours_Pizza_PizzaId",
                table: "Flours",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flours_Pizza_PizzaId",
                table: "Flours");

            migrationBuilder.DropIndex(
                name: "IX_Flours_PizzaId",
                table: "Flours");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "Flours");
        }
    }
}
