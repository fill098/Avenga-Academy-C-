using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentWaveApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNameOfMovie_Language_and_Genre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LanguageName",
                table: "Movies",
                newName: "Language");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "Movies",
                newName: "Genre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Language",
                table: "Movies",
                newName: "LanguageName");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Movies",
                newName: "GenreName");
        }
    }
}
