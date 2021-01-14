using Microsoft.EntityFrameworkCore.Migrations;

namespace Perpustakaan.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tm_anggota",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notelp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tm_anggota", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tm_buku",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    judul = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tm_buku", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tt_pinjam",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anggota_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buku_id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tt_pinjam", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tm_anggota");

            migrationBuilder.DropTable(
                name: "tm_buku");

            migrationBuilder.DropTable(
                name: "tt_pinjam");
        }
    }
}
