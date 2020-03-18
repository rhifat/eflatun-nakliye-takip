using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EflatunNakliyeTakip.Migrations
{
    public partial class Created_Gelir_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppGelirler",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IslemTarihi = table.Column<DateTime>(nullable: false),
                    Vasita = table.Column<string>(maxLength: 128, nullable: false),
                    YukCikisNoktasi = table.Column<string>(nullable: true),
                    YukVarisNoktasi = table.Column<string>(nullable: true),
                    YuklenenFirma = table.Column<string>(nullable: true),
                    GoturulecekFirma = table.Column<string>(nullable: true),
                    YukTonaj = table.Column<int>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Miktar = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGelirler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppGelirler");
        }
    }
}
