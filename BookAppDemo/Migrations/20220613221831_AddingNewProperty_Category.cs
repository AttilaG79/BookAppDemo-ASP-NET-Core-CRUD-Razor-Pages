using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAppDemo.Migrations
{
    public partial class AddingNewProperty_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Categories",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categories",
                table: "Books");
        }
    }
}
