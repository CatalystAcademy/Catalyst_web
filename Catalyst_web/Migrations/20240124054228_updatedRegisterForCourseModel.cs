using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalyst_web.Migrations
{
    /// <inheritdoc />
    public partial class updatedRegisterForCourseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "RegisterForCourses",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "RegisterForCourses");
        }
    }
}
