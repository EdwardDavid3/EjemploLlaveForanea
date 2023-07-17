using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EjemploLlaveForanea.Migrations
{
    /// <inheritdoc />
    public partial class inicialTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    IdMoneda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMoneda = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    PaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.IdMoneda);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePais = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    MonedaIdMoneda = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.IdPais);
                    table.ForeignKey(
                        name: "FK_Paises_Monedas_MonedaIdMoneda",
                        column: x => x.MonedaIdMoneda,
                        principalTable: "Monedas",
                        principalColumn: "IdMoneda");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paises_MonedaIdMoneda",
                table: "Paises",
                column: "MonedaIdMoneda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Monedas");
        }
    }
}
