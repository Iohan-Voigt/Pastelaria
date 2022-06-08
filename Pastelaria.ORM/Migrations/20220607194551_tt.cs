using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pastelaria.ORM.Migrations
{
    public partial class tt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PASTELARIA");

            migrationBuilder.CreateTable(
                name: "DOMAIN.CUSTOMER",
                schema: "PASTELARIA",
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
                schema: "PASTELARIA",
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
                schema: "PASTELARIA",
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
                    table.PrimaryKey("PK_DOMAIN.PRODUCT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PROCESSING.PRODUCT",
                schema: "PASTELARIA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(75)", nullable: false),
                    Value = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROCESSING.PRODUCT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DOMAIN.ORDERPAD",
                schema: "PASTELARIA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OpenTime = table.Column<DateTime>(type: "DATE", nullable: false),
                    OrderPadStatus = table.Column<int>(type: "INT", nullable: false),
                    OrderPadPaymentStatus = table.Column<int>(type: "INT", nullable: false),
                    Total = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    OrderPadId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOMAIN.ORDERPAD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DOMAIN.ORDERPAD_DOMAIN.CUSTOMER_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "PASTELARIA",
                        principalTable: "DOMAIN.CUSTOMER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DOMAIN.ORDERPAD_DOMAIN.EMPLOYEE_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "PASTELARIA",
                        principalTable: "DOMAIN.EMPLOYEE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DOMAIN.ORDERPAD_DOMAIN.ORDERPAD_OrderPadId",
                        column: x => x.OrderPadId,
                        principalSchema: "PASTELARIA",
                        principalTable: "DOMAIN.ORDERPAD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderPadProcessingProduct",
                schema: "PASTELARIA",
                columns: table => new
                {
                    OrderPadsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProcessingProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPadProcessingProduct", x => new { x.OrderPadsId, x.ProcessingProductsId });
                    table.ForeignKey(
                        name: "FK_OrderPadProcessingProduct_DOMAIN.ORDERPAD_OrderPadsId",
                        column: x => x.OrderPadsId,
                        principalSchema: "PASTELARIA",
                        principalTable: "DOMAIN.ORDERPAD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderPadProcessingProduct_PROCESSING.PRODUCT_ProcessingProductsId",
                        column: x => x.ProcessingProductsId,
                        principalSchema: "PASTELARIA",
                        principalTable: "PROCESSING.PRODUCT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DOMAIN.ORDERPAD_CustomerId",
                schema: "PASTELARIA",
                table: "DOMAIN.ORDERPAD",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_DOMAIN.ORDERPAD_EmployeeId",
                schema: "PASTELARIA",
                table: "DOMAIN.ORDERPAD",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DOMAIN.ORDERPAD_OrderPadId",
                schema: "PASTELARIA",
                table: "DOMAIN.ORDERPAD",
                column: "OrderPadId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPadProcessingProduct_ProcessingProductsId",
                schema: "PASTELARIA",
                table: "OrderPadProcessingProduct",
                column: "ProcessingProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DOMAIN.PRODUCT",
                schema: "PASTELARIA");

            migrationBuilder.DropTable(
                name: "OrderPadProcessingProduct",
                schema: "PASTELARIA");

            migrationBuilder.DropTable(
                name: "DOMAIN.ORDERPAD",
                schema: "PASTELARIA");

            migrationBuilder.DropTable(
                name: "PROCESSING.PRODUCT",
                schema: "PASTELARIA");

            migrationBuilder.DropTable(
                name: "DOMAIN.CUSTOMER",
                schema: "PASTELARIA");

            migrationBuilder.DropTable(
                name: "DOMAIN.EMPLOYEE",
                schema: "PASTELARIA");
        }
    }
}
