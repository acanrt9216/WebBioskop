using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBioskop.Migrations
{
    public partial class addMoviesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adult = table.Column<bool>(type: "bit", nullable: false),
                    backdrop_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id = table.Column<int>(type: "int", nullable: false),
                    original_language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    original_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    poster_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    release_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    video = table.Column<bool>(type: "bit", nullable: false),
                    vote_average = table.Column<double>(type: "float", nullable: false),
                    vote_count = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
