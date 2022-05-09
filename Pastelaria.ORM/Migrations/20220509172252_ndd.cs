using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pastelaria.ORM.Migrations
{
    public partial class ndd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBCOSTUMER",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    IdentityDocument = table.Column<string>(type: "VARCHAR(14)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCOSTUMER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBEMPLOYEE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AcessUser = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Registration = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    EmployeePermissionsEnum = table.Column<int>(type: "INT", nullable: false),
                    EmployeeActiveEnum = table.Column<int>(type: "INT", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    IdentityDocument = table.Column<string>(type: "VARCHAR(14)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBEMPLOYEE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBPRODUCT",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    Value = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPRODUCT", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBCOSTUMER");

            migrationBuilder.DropTable(
                name: "TBEMPLOYEE");

            migrationBuilder.DropTable(
                name: "TBPRODUCT");
        }
    }
}
