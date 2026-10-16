using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenameAddresToToAddressTo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddresTo",
                table: "Orders",
                newName: "AddressTo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressTo",
                table: "Orders",
                newName: "AddresTo");
        }
    }
}
