using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalyst_web.Migrations
{
    /// <inheritdoc />
    public partial class addedNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Newses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    ImageData = table.Column<byte[]>(type: "bytea", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Newses");
        }
    }
}
