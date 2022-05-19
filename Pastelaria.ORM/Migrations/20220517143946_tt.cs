using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pastelaria.ORM.Migrations
{
    public partial class tt : Migration
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
                name: "TBORDERPAD",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CostumerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OpenTime = table.Column<DateTime>(type: "DATE", nullable: false),
                    OrderPadStatus = table.Column<int>(type: "INT", nullable: false),
                    OrderPadPaymentStatus = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBORDERPAD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBORDERPAD_TBCOSTUMER_CostumerId",
                        column: x => x.CostumerId,
                        principalTable: "TBCOSTUMER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBORDERPAD_TBEMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "TBEMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBPRODUCT",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    Value = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    OrderPadId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPRODUCT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBPRODUCT_TBORDERPAD_OrderPadId",
                        column: x => x.OrderPadId,
                        principalTable: "TBORDERPAD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBORDERPAD_CostumerId",
                table: "TBORDERPAD",
                column: "CostumerId");

            migrationBuilder.CreateIndex(
                name: "IX_TBORDERPAD_EmployeeId",
                table: "TBORDERPAD",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TBPRODUCT_OrderPadId",
                table: "TBPRODUCT",
                column: "OrderPadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBPRODUCT");

            migrationBuilder.DropTable(
                name: "TBORDERPAD");

            migrationBuilder.DropTable(
                name: "TBCOSTUMER");

            migrationBuilder.DropTable(
                name: "TBEMPLOYEE");
        }
    }
}
