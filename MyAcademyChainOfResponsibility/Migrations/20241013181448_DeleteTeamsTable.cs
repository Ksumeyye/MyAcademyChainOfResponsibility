using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyChainOfResponsibility.Migrations
{
    public partial class DeleteTeamsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_CustomerProcesses_CustomerProcessId",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Team");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_CustomerProcessId",
                table: "Team",
                newName: "IX_Team_CustomerProcessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_CustomerProcesses_CustomerProcessId",
                table: "Team",
                column: "CustomerProcessId",
                principalTable: "CustomerProcesses",
                principalColumn: "CustomerProcessId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_CustomerProcesses_CustomerProcessId",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Teams");

            migrationBuilder.RenameIndex(
                name: "IX_Team_CustomerProcessId",
                table: "Teams",
                newName: "IX_Teams_CustomerProcessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_CustomerProcesses_CustomerProcessId",
                table: "Teams",
                column: "CustomerProcessId",
                principalTable: "CustomerProcesses",
                principalColumn: "CustomerProcessId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
