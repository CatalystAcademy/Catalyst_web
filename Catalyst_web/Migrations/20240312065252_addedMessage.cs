﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalyst_web.Migrations
{
    /// <inheritdoc />
    public partial class addedMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "FormDatas",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "FormDatas");
        }
    }
}
