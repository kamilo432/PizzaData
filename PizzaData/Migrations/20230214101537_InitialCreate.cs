using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaData.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlourName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlourAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WaterAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YeastAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OliveOilAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaltAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmbientFermentationTime = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FridgeFermentationTime = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizza");
        }
    }
}
