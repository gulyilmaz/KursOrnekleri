using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi_DataAcces.Migrations
{
    public partial class ekleyazar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YayineviID",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tb_Yayinevi",
                columns: table => new
                {
                    YayineviID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayinEviAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lokasyon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Yayinevi", x => x.YayineviID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_YayineviID",
                table: "tb_Kitap",
                column: "YayineviID");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tb_Yayinevi_YayineviID",
                table: "tb_Kitap",
                column: "YayineviID",
                principalTable: "tb_Yayinevi",
                principalColumn: "YayineviID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tb_Yayinevi_YayineviID",
                table: "tb_Kitap");

            migrationBuilder.DropTable(
                name: "tb_Yayinevi");

            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_YayineviID",
                table: "tb_Kitap");

            migrationBuilder.DropColumn(
                name: "YayineviID",
                table: "tb_Kitap");
        }
    }
}
