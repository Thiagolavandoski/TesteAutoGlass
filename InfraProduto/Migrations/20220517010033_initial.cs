using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace InfraProduto.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    CodigoDoProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoDoProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SituacaoDoProduto = table.Column<bool>(type: "bit", nullable: false),
                    DataDeFabricação = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeValidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoDoFornecedor = table.Column<int>(type: "int", nullable: false),
                    DescricaoDoFornecedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJDoFornecedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.CodigoDoProduto);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CodigoDoProduto",
                table: "Produtos",
                column: "CodigoDoProduto",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
