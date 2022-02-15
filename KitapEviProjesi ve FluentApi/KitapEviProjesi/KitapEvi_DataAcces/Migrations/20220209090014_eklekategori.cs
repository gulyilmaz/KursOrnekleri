using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi_DataAcces.Migrations
{
    public partial class eklekategori : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tb_Kategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Kategori", x => x.KategoriID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Kitap_KategoriID",
                table: "tb_Kitap",
                column: "KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tb_Kategori_KategoriID",
                table: "tb_Kitap",
                column: "KategoriID",
                principalTable: "tb_Kategori",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tb_Kategori_KategoriID",
                table: "tb_Kitap");

            migrationBuilder.DropTable(
                name: "tb_Kategori");

            migrationBuilder.DropIndex(
                name: "IX_tb_Kitap_KategoriID",
                table: "tb_Kitap");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "tb_Kitap");
        }
    }
}
