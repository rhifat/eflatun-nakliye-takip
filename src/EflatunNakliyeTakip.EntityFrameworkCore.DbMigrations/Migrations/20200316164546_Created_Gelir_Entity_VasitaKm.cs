using Microsoft.EntityFrameworkCore.Migrations;

namespace EflatunNakliyeTakip.Migrations
{
    public partial class Created_Gelir_Entity_VasitaKm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VasitaKm",
                table: "AppGelirler",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VasitaKm",
                table: "AppGelirler");
        }
    }
}
