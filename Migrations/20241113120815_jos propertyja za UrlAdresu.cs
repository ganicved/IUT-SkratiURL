using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IUTSkratiURL.Migrations
{
    /// <inheritdoc />
    public partial class jospropertyjazaUrlAdresu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrojPreusmjeravanja",
                table: "ADRESE_URL",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "ADRESE_URL",
                type: "TEXT",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "ADRESE_URL",
                type: "TEXT",
                maxLength: 1000,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojPreusmjeravanja",
                table: "ADRESE_URL");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "ADRESE_URL");

            migrationBuilder.DropColumn(
                name: "Opis",
                table: "ADRESE_URL");
        }
    }
}
