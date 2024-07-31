using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalGym.Migrations
{
    /// <inheritdoc />
    public partial class cityinfoupdate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FeePer30Minutes",
                table: "trainers",
                type: "Decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FeePer30Minutes",
                table: "trainers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(5,2)");
        }
    }
}
