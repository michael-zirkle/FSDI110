using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class InitialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    HP = table.Column<int>(nullable: false),
                    RentPrice = table.Column<decimal>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    Passengers = table.Column<int>(nullable: false),
                    GasMileage = table.Column<int>(nullable: false),
                    CargoSpace = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
