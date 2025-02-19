using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blogy.DataAccesLayer.Migrations
{
    public partial class mi_tag1tag2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tag1",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag2",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag3",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag1",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Tag2",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Tag3",
                table: "Tags");
        }
    }
}
