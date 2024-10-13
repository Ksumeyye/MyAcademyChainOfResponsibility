using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyChainOfResponsibility.Migrations
{
    public partial class DeleteTeamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerProcessId = table.Column<int>(type: "int", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Team_CustomerProcesses_CustomerProcessId",
                        column: x => x.CustomerProcessId,
                        principalTable: "CustomerProcesses",
                        principalColumn: "CustomerProcessId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Team_CustomerProcessId",
                table: "Team",
                column: "CustomerProcessId");
        }
    }
}
