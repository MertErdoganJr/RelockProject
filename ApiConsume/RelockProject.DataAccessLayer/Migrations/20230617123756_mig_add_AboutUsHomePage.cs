using Microsoft.EntityFrameworkCore.Migrations;

namespace RelockProject.DataAccessLayer.Migrations
{
    public partial class mig_add_AboutUsHomePage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUsHomePages",
                columns: table => new
                {
                    AboutUsHomePageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsHomePages", x => x.AboutUsHomePageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUsHomePages");
        }
    }
}
