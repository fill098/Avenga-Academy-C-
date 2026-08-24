using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDataBaseFirstDemo.Migrations
{
    /// <inheritdoc />
    public partial class Add_SoftDelete_In_Note_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Todo",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Todo");
        }
    }
}
