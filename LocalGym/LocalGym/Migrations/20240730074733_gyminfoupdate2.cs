using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalGym.Migrations
{
    /// <inheritdoc />
    public partial class gyminfoupdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "trainers",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "First_name",
                table: "trainers",
                newName: "Firstname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "trainers",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "trainers",
                newName: "First_name");
        }
    }
}
