using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nest_AspNet.Migrations
{
    public partial class NestAspNet_isHover : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHover",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHover",
                table: "ProductImages");
        }
    }
}
