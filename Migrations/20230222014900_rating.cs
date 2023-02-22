using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB315_Trekking_Locations_Asg_01.Migrations
{
    public partial class rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "ThemeTrekking",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Popularity",
                table: "ThemeTrekking",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisitorName",
                table: "ThemeTrekking",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "ThemeTrekking");

            migrationBuilder.DropColumn(
                name: "Popularity",
                table: "ThemeTrekking");

            migrationBuilder.DropColumn(
                name: "VisitorName",
                table: "ThemeTrekking");
        }
    }
}
