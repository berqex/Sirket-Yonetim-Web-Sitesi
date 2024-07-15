using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proje.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_GorevDepartmans",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmanAd = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: true),
                    Detay = table.Column<string>(type: "VARCHAR(50)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GorevDepartmans", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "_Personels",
                columns: table => new
                {
                    perid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ad = table.Column<string>(type: "VARCHAR(5)", maxLength: 30, nullable: true),
                    soyad = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: true),
                    sehir = table.Column<string>(type: "VARCHAR(30)", maxLength: 50, nullable: true),
                    departid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Personels", x => x.perid);
                    table.ForeignKey(
                        name: "FK__Personels__GorevDepartmans_departid",
                        column: x => x.departid,
                        principalTable: "_GorevDepartmans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__Personels_departid",
                table: "_Personels",
                column: "departid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_Personels");

            migrationBuilder.DropTable(
                name: "_GorevDepartmans");
        }
    }
}
