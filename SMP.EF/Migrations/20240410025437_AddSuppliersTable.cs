using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMP.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddSuppliersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Supp_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supp_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supp_Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
