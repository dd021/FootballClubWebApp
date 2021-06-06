using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace FootballClubWebApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(nullable: true),
                    CountryID = table.Column<int>(nullable: false),
                    CountryInfoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamInfos_CountryInfos_CountryInfoId",
                        column: x => x.CountryInfoId,
                        principalTable: "CountryInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rankings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueInMillions = table.Column<int>(nullable: false),
                    OperatingIncome = table.Column<int>(nullable: false),
                    TeamID = table.Column<int>(nullable: false),
                    TeamInfoId = table.Column<int>(nullable: true),
                    YearID = table.Column<int>(nullable: false),
                    YearInfoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rankings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rankings_TeamInfos_TeamInfoId",
                        column: x => x.TeamInfoId,
                        principalTable: "TeamInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rankings_YearInfos_YearInfoId",
                        column: x => x.YearInfoId,
                        principalTable: "YearInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rankings_TeamInfoId",
                table: "Rankings",
                column: "TeamInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Rankings_YearInfoId",
                table: "Rankings",
                column: "YearInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamInfos_CountryInfoId",
                table: "TeamInfos",
                column: "CountryInfoId");

            var sqlFile = Path.Combine(".\\Data", @"club_data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rankings");

            migrationBuilder.DropTable(
                name: "TeamInfos");

            migrationBuilder.DropTable(
                name: "YearInfos");

            migrationBuilder.DropTable(
                name: "CountryInfos");
        }
    }
}
