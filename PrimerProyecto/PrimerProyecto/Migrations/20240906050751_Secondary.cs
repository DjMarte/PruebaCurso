using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimerProyecto.Migrations
{
    /// <inheritdoc />
    public partial class Secondary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiasSemanas",
                columns: table => new
                {
                    DiasSemanasId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dias = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiasSemanas", x => x.DiasSemanasId);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Matricula = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false),
                    Carrera = table.Column<string>(type: "TEXT", nullable: false),
                    DiaId = table.Column<int>(type: "INTEGER", nullable: false),
                    //DiasSemanasId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteId);
                    table.ForeignKey(
                        name: "FK_Estudiantes_DiasSemanas_DiaId",
                        column: x => x.DiaId,
                        principalTable: "DiasSemanas",
                        principalColumn: "DiasSemanasId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiantes_DiasSemanasId",
                table: "Estudiantes",
                column: "DiasSemanasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "DiasSemanas");
        }
    }
}
