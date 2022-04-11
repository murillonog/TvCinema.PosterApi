using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TvCinema.PosterApi.Service.Infrastructure.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: true),
                    AspectRatio = table.Column<double>(type: "double precision", nullable: false),
                    Language = table.Column<string>(type: "text", nullable: true),
                    Width = table.Column<int>(type: "integer", nullable: false),
                    Height = table.Column<int>(type: "integer", nullable: false),
                    ImdbId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posters");
        }
    }
}
