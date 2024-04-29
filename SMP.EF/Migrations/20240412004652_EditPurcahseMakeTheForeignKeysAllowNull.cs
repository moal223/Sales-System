using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMP.EF.Migrations
{
    /// <inheritdoc />
    public partial class EditPurcahseMakeTheForeignKeysAllowNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Categories_CategoriesId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Suppliers_SuppliersId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Supplier_Id",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "SuppliersId",
                table: "Purchase",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriesId",
                table: "Purchase",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Categories_CategoriesId",
                table: "Purchase",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Suppliers_SuppliersId",
                table: "Purchase",
                column: "SuppliersId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Categories_CategoriesId",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Suppliers_SuppliersId",
                table: "Purchase");

            migrationBuilder.AlterColumn<int>(
                name: "SuppliersId",
                table: "Purchase",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriesId",
                table: "Purchase",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "Purchase",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Supplier_Id",
                table: "Purchase",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Categories_CategoriesId",
                table: "Purchase",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Suppliers_SuppliersId",
                table: "Purchase",
                column: "SuppliersId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
