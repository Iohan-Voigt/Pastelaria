using Microsoft.EntityFrameworkCore.Migrations;

namespace Pastelaria.ORM.Migrations
{
    public partial class mg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeActiveEnum",
                table: "TBEMPLOYEE",
                type: "INT",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeActiveEnum",
                table: "TBEMPLOYEE");
        }
    }
}
