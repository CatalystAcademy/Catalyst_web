using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalyst_web.Migrations
{
    /// <inheritdoc />
    public partial class addedNewPropsToCurriculum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurriculumDescriptionTitleArm",
                table: "Curriculums",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CurriculumDescriptionTitleEng",
                table: "Curriculums",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Curriculums",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Curriculums",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lectures",
                table: "Curriculums",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Curriculums",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillLevel",
                table: "Curriculums",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Students",
                table: "Curriculums",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentsCountOnCurriculum",
                table: "Curriculums",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurriculumDescriptionTitleArm",
                table: "Curriculums");

            migrationBuilder.DropColumn(
                name: "CurriculumDescriptionTitleEng",
                table: "Curriculums");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Curriculums");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Curriculums");

            migrationBuilder.DropColumn(
                name: "Lectures",
                table: "Curriculums");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Curriculums");

            migrationBuilder.DropColumn(
                name: "SkillLevel",
                table: "Curriculums");

            migrationBuilder.DropColumn(
                name: "Students",
                table: "Curriculums");

            migrationBuilder.DropColumn(
                name: "StudentsCountOnCurriculum",
                table: "Curriculums");
        }
    }
}
