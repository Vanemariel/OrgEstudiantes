using Microsoft.EntityFrameworkCore.Migrations;

namespace OrgEstudiantes.Comunes.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodMateria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreMateria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreEstudiante = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno");
        }
    }
}
