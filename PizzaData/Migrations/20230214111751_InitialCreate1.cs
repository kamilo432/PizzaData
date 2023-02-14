using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlourName",
                table: "Pizza");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pizza",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Flours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlourName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlourType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Protein = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Elasticity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlourDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flours", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flours");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pizza");

            migrationBuilder.AddColumn<string>(
                name: "FlourName",
                table: "Pizza",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
