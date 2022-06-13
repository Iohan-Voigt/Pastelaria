using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pastelaria.ORM.Migrations
{
    public partial class tt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DOMAIN.CUSTOMER",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    IdentityDocument = table.Column<string>(type: "VARCHAR(14)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOMAIN.CUSTOMER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DOMAIN.EMPLOYEE",
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
                    table.PrimaryKey("PK_DOMAIN.EMPLOYEE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DOMAIN.PRODUCT",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    Value = table.Column<decimal>(type: "DECIMAL(25,2)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOMAIN.PRODUCT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DOMAIN.ORDERPAD",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OpenTime = table.Column<DateTime>(type: "DATE", nullable: false),
                    OrderPadStatus = table.Column<int>(type: "INT", nullable: false),
                    OrderPadPaymentStatus = table.Column<int>(type: "INT", nullable: false),
                    Total = table.Column<decimal>(type: "DECIMAL(25,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOMAIN.ORDERPAD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DOMAIN.ORDERPAD_DOMAIN.CUSTOMER_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "DOMAIN.CUSTOMER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DOMAIN.ORDERPAD_DOMAIN.EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "DOMAIN.EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROCESSING.PRODUCT",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderPadId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    Value = table.Column<decimal>(type: "DECIMAL(25,2)", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROCESSING.PRODUCT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROCESSING.PRODUCT_DOMAIN.ORDERPAD_OrderPadId",
                        column: x => x.OrderPadId,
                        principalTable: "DOMAIN.ORDERPAD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DOMAIN.ORDERPAD_CustomerId",
                table: "DOMAIN.ORDERPAD",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_DOMAIN.ORDERPAD_EmployeeId",
                table: "DOMAIN.ORDERPAD",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PROCESSING.PRODUCT_OrderPadId",
                table: "PROCESSING.PRODUCT",
                column: "OrderPadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOMAIN.PRODUCT");

            migrationBuilder.DropTable(
                name: "PROCESSING.PRODUCT");

            migrationBuilder.DropTable(
                name: "DOMAIN.ORDERPAD");

            migrationBuilder.DropTable(
                name: "DOMAIN.CUSTOMER");

            migrationBuilder.DropTable(
                name: "DOMAIN.EMPLOYEE");
        }
    }
}
