using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUTSkratiURL.Migrations
{
    /// <inheritdoc />
    public partial class URLadrese : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADRESE_URL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DestinacijaUrl = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    SkraceniUrl = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    DatumKreiranja = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsAktivan = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsObrisan = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADRESE_URL", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADRESE_URL");
        }
    }
}
