using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppDay51.Migrations
{
    public partial class myMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PPicModel",
                columns: table => new
                {
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PTeam = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PCategory = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PPicModel", x => x.PId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PPicModel");
        }
    }
}
