using Microsoft.EntityFrameworkCore.Migrations;

namespace Reader.Migrations
{
    public partial class RaceName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RaceName",
                table: "Tags",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RaceName",
                table: "Tags");
        }
    }
}
