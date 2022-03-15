using Microsoft.EntityFrameworkCore.Migrations;

namespace OrgEstudiantes.Comunes.Migrations
{
    public partial class Completatablaestudiante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Alumnos",
                table: "Alumnos");

            migrationBuilder.RenameTable(
                name: "Alumnos",
                newName: "Alumno");

            migrationBuilder.AlterColumn<string>(
                name: "NombreMateria",
                table: "Alumno",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreEstudiante",
                table: "Alumno",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodMateria",
                table: "Alumno",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alumno",
                table: "Alumno",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "Uq_Estudiantes_CodEstudiantes",
                table: "Alumno",
                column: "CodMateria",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Uq_Estudiantes_CodMareria",
                table: "Alumno",
                column: "CodMateria",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Alumno",
                table: "Alumno");

            migrationBuilder.DropIndex(
                name: "Uq_Estudiantes_CodEstudiantes",
                table: "Alumno");

            migrationBuilder.DropIndex(
                name: "Uq_Estudiantes_CodMareria",
                table: "Alumno");

            migrationBuilder.RenameTable(
                name: "Alumno",
                newName: "Alumnos");

            migrationBuilder.AlterColumn<string>(
                name: "NombreMateria",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "NombreEstudiante",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "CodMateria",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alumnos",
                table: "Alumnos",
                column: "Id");
        }
    }
}
