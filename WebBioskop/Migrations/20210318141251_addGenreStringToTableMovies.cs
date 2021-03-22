using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBioskop.Migrations
{
    public partial class addGenreStringToTableMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(name:"genre_ids",table:"Movies", nullable: false,defaultValue:"aaa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "genre_ids", table: "Movies");
        }
    }
}
