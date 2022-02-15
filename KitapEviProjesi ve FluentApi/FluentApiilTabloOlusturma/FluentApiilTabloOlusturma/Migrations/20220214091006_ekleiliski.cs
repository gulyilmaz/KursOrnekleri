using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiilTabloOlusturma.Migrations
{
    public partial class ekleiliski : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "firID",
                table: "Tbl_Personel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Personel_firID",
                table: "Tbl_Personel",
                column: "firID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Personel_Tbl_Firma_firID",
                table: "Tbl_Personel",
                column: "firID",
                principalTable: "Tbl_Firma",
                principalColumn: "Anahtar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Personel_Tbl_Firma_firID",
                table: "Tbl_Personel");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Personel_firID",
                table: "Tbl_Personel");

            migrationBuilder.DropColumn(
                name: "firID",
                table: "Tbl_Personel");
        }
    }
}
