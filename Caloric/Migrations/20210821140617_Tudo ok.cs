using Microsoft.EntityFrameworkCore.Migrations;

namespace Caloric.Migrations
{
    public partial class Tudook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PessoasId",
                table: "Enderecos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PessoasId",
                table: "CaracteristicasFisicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AlimentosNutrientes",
                columns: table => new
                {
                    AlimenntosAlimentosId = table.Column<int>(type: "int", nullable: false),
                    NutrientesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlimentosNutrientes", x => new { x.AlimenntosAlimentosId, x.NutrientesId });
                    table.ForeignKey(
                        name: "FK_AlimentosNutrientes_Alimentos_AlimenntosAlimentosId",
                        column: x => x.AlimenntosAlimentosId,
                        principalTable: "Alimentos",
                        principalColumn: "AlimentosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlimentosNutrientes_Nutrientes_NutrientesId",
                        column: x => x.NutrientesId,
                        principalTable: "Nutrientes",
                        principalColumn: "NutrientesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NutrientesAlimentos",
                columns: table => new
                {
                    AlimentosId = table.Column<int>(type: "int", nullable: false),
                    NutrientesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutrientesAlimentos", x => new { x.AlimentosId, x.NutrientesId });
                    table.ForeignKey(
                        name: "FK_NutrientesAlimentos_Alimentos_AlimentosId",
                        column: x => x.AlimentosId,
                        principalTable: "Alimentos",
                        principalColumn: "AlimentosId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NutrientesAlimentos_Nutrientes_NutrientesId",
                        column: x => x.NutrientesId,
                        principalTable: "Nutrientes",
                        principalColumn: "NutrientesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_PessoasId",
                table: "Enderecos",
                column: "PessoasId");

            migrationBuilder.CreateIndex(
                name: "IX_CaracteristicasFisicas_PessoasId",
                table: "CaracteristicasFisicas",
                column: "PessoasId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlimentosNutrientes_NutrientesId",
                table: "AlimentosNutrientes",
                column: "NutrientesId");

            migrationBuilder.CreateIndex(
                name: "IX_NutrientesAlimentos_NutrientesId",
                table: "NutrientesAlimentos",
                column: "NutrientesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaracteristicasFisicas_Pessoas_PessoasId",
                table: "CaracteristicasFisicas",
                column: "PessoasId",
                principalTable: "Pessoas",
                principalColumn: "PessoasId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Pessoas_PessoasId",
                table: "Enderecos",
                column: "PessoasId",
                principalTable: "Pessoas",
                principalColumn: "PessoasId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaracteristicasFisicas_Pessoas_PessoasId",
                table: "CaracteristicasFisicas");

            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Pessoas_PessoasId",
                table: "Enderecos");

            migrationBuilder.DropTable(
                name: "AlimentosNutrientes");

            migrationBuilder.DropTable(
                name: "NutrientesAlimentos");

            migrationBuilder.DropIndex(
                name: "IX_Enderecos_PessoasId",
                table: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_CaracteristicasFisicas_PessoasId",
                table: "CaracteristicasFisicas");

            migrationBuilder.DropColumn(
                name: "PessoasId",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "PessoasId",
                table: "CaracteristicasFisicas");
        }
    }
}
