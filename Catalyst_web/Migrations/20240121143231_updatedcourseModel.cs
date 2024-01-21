using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalyst_web.Migrations
{
    /// <inheritdoc />
    public partial class updatedcourseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Courses",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Courses",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Courses");
        }
    }
}
