using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoUrna.Migrations
{
    public partial class entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Presidente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomePresidente = table.Column<string>(nullable: true),
                    NomeVice = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    PartidoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presidente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Presidente_Partido_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TotalVoto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataVoto = table.Column<DateTime>(nullable: false),
                    PresidenteId = table.Column<int>(nullable: true),
                    Situacao = table.Column<int>(nullable: false),
                    Soma = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalVoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TotalVoto_Presidente_PresidenteId",
                        column: x => x.PresidenteId,
                        principalTable: "Presidente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Presidente_PartidoId",
                table: "Presidente",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalVoto_PresidenteId",
                table: "TotalVoto",
                column: "PresidenteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TotalVoto");

            migrationBuilder.DropTable(
                name: "Presidente");
        }
    }
}
