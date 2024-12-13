using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _420DA3_Examen_Final.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auteurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "livres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    Isbn = table.Column<string>(type: "nvarchar(32)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuteursLivres",
                columns: table => new
                {
                    AuteurId = table.Column<int>(type: "int", nullable: false),
                    LivreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuteursLivres", x => new { x.AuteurId, x.LivreId });
                    table.ForeignKey(
                        name: "FK_AuteursLivres_Auteurs_AuteurId",
                        column: x => x.AuteurId,
                        principalTable: "Auteurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuteursLivres_livres_LivreId",
                        column: x => x.LivreId,
                        principalTable: "livres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Auteurs",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Isaac", "Asimov" },
                    { 2, "Alastair", "Reynolds" },
                    { 3, "Peter F", "Hamilton" }
                });

            migrationBuilder.InsertData(
                table: "livres",
                columns: new[] { "Id", "Isbn", "Titre" },
                values: new object[,]
                {
                    { 1, "978-0-553-29335-7", "Foundation" },
                    { 2, "978-0-575-06875-9", "Revelation Space " }
                });

            migrationBuilder.InsertData(
                table: "AuteursLivres",
                columns: new[] { "AuteurId", "LivreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuteursLivres_LivreId",
                table: "AuteursLivres",
                column: "LivreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuteursLivres");

            migrationBuilder.DropTable(
                name: "Auteurs");

            migrationBuilder.DropTable(
                name: "livres");
        }
    }
}
