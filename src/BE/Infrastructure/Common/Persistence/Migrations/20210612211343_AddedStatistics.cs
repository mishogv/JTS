using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JTSystem.Infrastructure.Migrations
{
    public partial class AddedStatistics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JudokaViews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JudokaId = table.Column<int>(nullable: false),
                    When = table.Column<DateTime>(nullable: false),
                    StatisticsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JudokaViews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JudokaViews_Judokas_JudokaId",
                        column: x => x.JudokaId,
                        principalTable: "Judokas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JudokaViews_Statistics_StatisticsId",
                        column: x => x.StatisticsId,
                        principalTable: "Statistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TournamentViews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(nullable: false),
                    When = table.Column<DateTime>(nullable: false),
                    StatisticsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentViews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentViews_Statistics_StatisticsId",
                        column: x => x.StatisticsId,
                        principalTable: "Statistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TournamentViews_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JudokaViews_JudokaId",
                table: "JudokaViews",
                column: "JudokaId");

            migrationBuilder.CreateIndex(
                name: "IX_JudokaViews_StatisticsId",
                table: "JudokaViews",
                column: "StatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentViews_StatisticsId",
                table: "TournamentViews",
                column: "StatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentViews_TournamentId",
                table: "TournamentViews",
                column: "TournamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JudokaViews");

            migrationBuilder.DropTable(
                name: "TournamentViews");

            migrationBuilder.DropTable(
                name: "Statistics");
        }
    }
}
