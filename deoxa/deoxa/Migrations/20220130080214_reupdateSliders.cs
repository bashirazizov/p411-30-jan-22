using Microsoft.EntityFrameworkCore.Migrations;

namespace deoxa.Migrations
{
    public partial class reupdateSliders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ButtonIcon",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButtonIcon",
                table: "Sliders");
        }
    }
}
