using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMP.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddSellOperationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SellOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sell_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sell_Cus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    TPrice = table.Column<float>(type: "real", nullable: false),
                    Sell_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SellOperations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SellOperations_CustomerId",
                table: "SellOperations",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellOperations");
        }
    }
}
