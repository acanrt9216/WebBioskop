using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBioskop.Migrations
{
    public partial class addSeriesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    serieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    backdrop_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    first_air_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    original_language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    original_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    popularity = table.Column<double>(type: "float", nullable: false),
                    poster_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vote_average = table.Column<double>(type: "float", nullable: false),
                    vote_count = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.serieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}
