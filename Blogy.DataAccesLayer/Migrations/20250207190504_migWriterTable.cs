using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blogy.DataAccesLayer.Migrations
{
    public partial class migWriterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WriterId",
                table: "Writers",
                newName: "WriterTableId");

            migrationBuilder.AddColumn<string>(
                name: "PasswordConfirm",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordConfirm",
                table: "Writers");

            migrationBuilder.RenameColumn(
                name: "WriterTableId",
                table: "Writers",
                newName: "WriterId");
        }
    }
}
