using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBioskop.Migrations
{
    public partial class addGenreStringToTableSeries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "genre_ids",
                table: "Series",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue:"aaa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "genre_ids",
                table: "Series");
        }
    }
}
