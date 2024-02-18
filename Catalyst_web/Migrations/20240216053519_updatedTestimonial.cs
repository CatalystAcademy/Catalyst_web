using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalyst_web.Migrations
{
    /// <inheritdoc />
    public partial class updatedTestimonial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Testimonials",
                newName: "TextEng");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Testimonials",
                newName: "TextArm");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Testimonials",
                newName: "PositionEng");

            migrationBuilder.AddColumn<string>(
                name: "FullNameArm",
                table: "Testimonials",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullNameEng",
                table: "Testimonials",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PositionArm",
                table: "Testimonials",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullNameArm",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "FullNameEng",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "PositionArm",
                table: "Testimonials");

            migrationBuilder.RenameColumn(
                name: "TextEng",
                table: "Testimonials",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "TextArm",
                table: "Testimonials",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "PositionEng",
                table: "Testimonials",
                newName: "FullName");
        }
    }
}
