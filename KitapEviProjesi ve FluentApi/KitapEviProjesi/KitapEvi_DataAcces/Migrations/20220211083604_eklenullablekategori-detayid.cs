using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi_DataAcces.Migrations
{
    public partial class eklenullablekategoridetayid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tb_Kategori_KategoriID",
                table: "tb_Kitap");

            migrationBuilder.DropIndex(
                name: "IX_KitapDetaylar_KitapID",
                table: "KitapDetaylar");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriID",
                table: "tb_Kitap",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KitapDetayID",
                table: "tb_Kitap",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KitapDetaylar_KitapID",
                table: "KitapDetaylar",
                column: "KitapID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tb_Kategori_KategoriID",
                table: "tb_Kitap",
                column: "KategoriID",
                principalTable: "tb_Kategori",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Kitap_tb_Kategori_KategoriID",
                table: "tb_Kitap");

            migrationBuilder.DropIndex(
                name: "IX_KitapDetaylar_KitapID",
                table: "KitapDetaylar");

            migrationBuilder.DropColumn(
                name: "KitapDetayID",
                table: "tb_Kitap");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriID",
                table: "tb_Kitap",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_KitapDetaylar_KitapID",
                table: "KitapDetaylar",
                column: "KitapID");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Kitap_tb_Kategori_KategoriID",
                table: "tb_Kitap",
                column: "KategoriID",
                principalTable: "tb_Kategori",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
