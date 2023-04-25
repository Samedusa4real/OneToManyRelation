using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaAgain.Migrations
{
    public partial class PositionIdAddedToTeamMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "TeamMembers");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "TeamMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "TeamMembers");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "TeamMembers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
