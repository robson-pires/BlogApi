using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApi.Migrations
{
    public partial class AddColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Posts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Posts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Posts");
        }
    }
}
