using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMP.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddPurchasesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pur_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pur_Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pur_Cat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pur_Supp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pur_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pur_Buy = table.Column<double>(type: "float", nullable: true),
                    Pur_Sell = table.Column<double>(type: "float", nullable: true),
                    Pur_Qt = table.Column<double>(type: "float", nullable: true),
                    Pur_TSell = table.Column<double>(type: "float", nullable: true),
                    Pur_TBuy = table.Column<double>(type: "float", nullable: true),
                    Pur_TRev = table.Column<double>(type: "float", nullable: true),
                    Category_Id = table.Column<int>(type: "int", nullable: true),
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    Supplier_Id = table.Column<int>(type: "int", nullable: true),
                    SuppliersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchase_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchase_Suppliers_SuppliersId",
                        column: x => x.SuppliersId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CategoriesId",
                table: "Purchase",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_SuppliersId",
                table: "Purchase",
                column: "SuppliersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchase");
        }
    }
}
