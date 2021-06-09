using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.CodeAnalysis;

namespace CursoMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up([NotNull]MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation(name:"SqlServer:Identity", value:"1, 1"),
                    Descrição = table.Column<string>( nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey(name: "PK_Categorias",columns: x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}

