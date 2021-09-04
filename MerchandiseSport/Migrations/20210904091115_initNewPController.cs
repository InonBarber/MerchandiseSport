using Microsoft.EntityFrameworkCore.Migrations;

namespace MerchandiseSport.Migrations
{
    public partial class initNewPController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productType",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productType",
                table: "Product");
        }
    }
}
