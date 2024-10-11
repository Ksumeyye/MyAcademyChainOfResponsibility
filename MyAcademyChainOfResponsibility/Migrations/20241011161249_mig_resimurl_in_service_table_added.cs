using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademyChainOfResponsibility.Migrations
{
    public partial class mig_resimurl_in_service_table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResimUrl",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResimUrl",
                table: "Services");
        }
    }
}
