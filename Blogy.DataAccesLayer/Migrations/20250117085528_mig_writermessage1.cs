﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blogy.DataAccesLayer.Migrations
{
    public partial class mig_writermessage1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "writerMessages",
                newName: "MessageContent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageContent",
                table: "writerMessages",
                newName: "Content");
        }
    }
}
