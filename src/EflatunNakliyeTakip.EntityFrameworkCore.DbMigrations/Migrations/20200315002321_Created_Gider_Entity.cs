using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EflatunNakliyeTakip.Migrations
{
    public partial class Created_Gider_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppGiderler",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Vasita = table.Column<string>(maxLength: 128, nullable: false),
                    Masraf = table.Column<int>(nullable: false),
                    IslemTarihi = table.Column<DateTime>(nullable: false),
                    Aciklama = table.Column<string>(nullable: true),
                    Miktar = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppGiderler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppGiderler");
        }
    }
}
