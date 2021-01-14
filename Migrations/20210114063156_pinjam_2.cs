using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Perpustakaan.Migrations
{
    public partial class pinjam_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "tanggal_pengembalian",
                table: "tt_pinjam",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tanggal_pengembalian",
                table: "tt_pinjam");
        }
    }
}
