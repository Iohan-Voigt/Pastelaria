using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pastelaria.ORM.Migrations
{
    public partial class PastelariaDbv01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBEMPLOYEE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcessUser = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Registration = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    EmployeePermissionsEnum = table.Column<int>(type: "INT", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    IndentityDocument = table.Column<string>(type: "VARCHAR(14)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBEMPLOYEE", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBEMPLOYEE");
        }
    }
}
