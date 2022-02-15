using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiilTabloOlusturma.Migrations
{
    public partial class ekletabloprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isim",
                table: "Tbl_Personel",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Telefon",
                table: "Tbl_Personel",
                newName: "TelefonNumara");

            migrationBuilder.RenameColumn(
                name: "Soyisim",
                table: "Tbl_Personel",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tbl_Personel",
                newName: "Anahtar_Personel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelefonNumara",
                table: "Tbl_Personel",
                newName: "Telefon");

            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "Tbl_Personel",
                newName: "Soyisim");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "Tbl_Personel",
                newName: "isim");

            migrationBuilder.RenameColumn(
                name: "Anahtar_Personel",
                table: "Tbl_Personel",
                newName: "ID");
        }
    }
}
