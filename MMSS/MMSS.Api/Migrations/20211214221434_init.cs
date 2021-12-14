using Microsoft.EntityFrameworkCore.Migrations;

namespace MMSS.Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShowTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Briefing = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShowTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlatformId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shows_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shows_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shows_ShowTypes_ShowTypeId",
                        column: x => x.ShowTypeId,
                        principalTable: "ShowTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlatformsShows",
                columns: table => new
                {
                    ShowId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlatformId = table.Column<string>(type: "TEXT", nullable: false),
                    PlatformId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatformsShows", x => new { x.PlatformId, x.ShowId });
                    table.ForeignKey(
                        name: "FK_PlatformsShows_Platforms_PlatformId1",
                        column: x => x.PlatformId1,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlatformsShows_Shows_ShowId",
                        column: x => x.ShowId,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShowsCategorys",
                columns: table => new
                {
                    ShowId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowsCategorys", x => new { x.ShowId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ShowsCategorys_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShowsCategorys_Shows_ShowId",
                        column: x => x.ShowId,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Drama" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Musical" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Comédia" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Terror" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Policial" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Ação" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "SciFi" });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Suspense" });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Amazon" });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "YouTube" });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Netflix" });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "TV" });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Disney+" });

            migrationBuilder.InsertData(
                table: "ShowTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Filme" });

            migrationBuilder.InsertData(
                table: "ShowTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Série" });

            migrationBuilder.InsertData(
                table: "ShowTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Programa de TV" });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Briefing", "CategoryId", "PlatformId", "ShowTypeId", "Title", "Year" },
                values: new object[] { 2, "Com a ajuda de Jim Gordon e Harvey Dent, Batman tem mantido a ordem na cidade de Gotham. Mas um jovem e anárquico criminoso conhecido como Coringa ganha força e decide instaurar um verdadeiro caos na cidade. O justiceiro será testado psicologicamente e fisicamente como nunca fora antes em um confronto bastante pessoal. Cabe a Batman encontrar uma maneira de deter o sádico vilão antes que mais vidas sejam perdidas.", 6, 1, 1, "Batman: O Cavaleiro das Trevas", 2008 });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Briefing", "CategoryId", "PlatformId", "ShowTypeId", "Title", "Year" },
                values: new object[] { 3, "Um assassinato no museu do Louvre em Paris e pistas enigmáticas em alguns dos quadros mais famosos de Leonardo DaVinci levam à descoberta de um mistério religioso. Por mais de dois mil anos, uma sociedade secreta guarda informações que, se descobertas, poderiam comprometer o cristianismo. Robert Langdon, um professor especialista em simbologia e história, se envolve na investigação.", 5, 3, 1, "O Código DaVinci", 2006 });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Briefing", "CategoryId", "PlatformId", "ShowTypeId", "Title", "Year" },
                values: new object[] { 4, "Uma jovem e talentosa agente do FBI é aconselhada pelo Dr. Hannibal Lecter, um psiquiatra brilhante e também um psicopata violento e canibal, a fim de conseguir capturar outro assassino.", 8, 2, 1, "O Silêncio dos Inocentes", 1991 });

            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Briefing", "CategoryId", "PlatformId", "ShowTypeId", "Title", "Year" },
                values: new object[] { 1, "Os melhores amigos e companheiros de apartamento Leonard e Sheldon são físicos que trabalham no Instituto Tecnológico da Califórnia (Caltech) e são capazes de explicar a todo mundo mais do que gostariam de saber sobre física quântica, mas superar as situações sociais mais básicas, especialmente aquelas envolvendo mulheres, os deixa completamente perdidos. Que sorte quando a gostosa garçonete/atriz aspirante Penny se muda para o apartamento ao lado. Wolowitz e Koothrappali, também da Caltech, são vistos frequentemente passando o tempo com Leonard e Sheldon. Será que os mundos vão se colidir? Será que Einstein teorizava na floresta?", 3, 4, 2, "The Big Bang Theory", 2007 });

            migrationBuilder.CreateIndex(
                name: "IX_PlatformsShows_PlatformId1",
                table: "PlatformsShows",
                column: "PlatformId1");

            migrationBuilder.CreateIndex(
                name: "IX_PlatformsShows_ShowId",
                table: "PlatformsShows",
                column: "ShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_CategoryId",
                table: "Shows",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_PlatformId",
                table: "Shows",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_ShowTypeId",
                table: "Shows",
                column: "ShowTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowsCategorys_CategoryId",
                table: "ShowsCategorys",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlatformsShows");

            migrationBuilder.DropTable(
                name: "ShowsCategorys");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "ShowTypes");
        }
    }
}
