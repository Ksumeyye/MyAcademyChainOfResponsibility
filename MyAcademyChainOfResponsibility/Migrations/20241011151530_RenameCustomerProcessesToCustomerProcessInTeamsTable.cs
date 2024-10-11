using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyChainOfResponsibility.Migrations
{
    public partial class RenameCustomerProcessesToCustomerProcessInTeamsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_CustomerProcesses_CustomerProcessesCustomerProcessId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "CustomerProcessesCustomerProcessId",
                table: "Teams",
                newName: "CustomerProcessId");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_CustomerProcessesCustomerProcessId",
                table: "Teams",
                newName: "IX_Teams_CustomerProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_CustomerProcesses_CustomerProcessId",
                table: "Teams",
                column: "CustomerProcessId",
                principalTable: "CustomerProcesses",
                principalColumn: "CustomerProcessId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_CustomerProcesses_CustomerProcessId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "CustomerProcessId",
                table: "Teams",
                newName: "CustomerProcessesCustomerProcessId");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_CustomerProcessId",
                table: "Teams",
                newName: "IX_Teams_CustomerProcessesCustomerProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_CustomerProcesses_CustomerProcessesCustomerProcessId",
                table: "Teams",
                column: "CustomerProcessesCustomerProcessId",
                principalTable: "CustomerProcesses",
                principalColumn: "CustomerProcessId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
