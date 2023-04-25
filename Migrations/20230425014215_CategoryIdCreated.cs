using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaAgain.Migrations
{
    public partial class CategoryIdCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Portfolios");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Portfolios");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
