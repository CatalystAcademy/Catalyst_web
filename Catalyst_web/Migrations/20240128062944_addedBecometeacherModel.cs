using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalyst_web.Migrations
{
    /// <inheritdoc />
    public partial class addedBecometeacherModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Newses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "RegisterForCourses",
                newName: "ParentPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Courses",
                newName: "TitleEng");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Courses",
                newName: "TitleArm");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "RegisterForCourses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionArm",
                table: "Newses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEng",
                table: "Newses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleArm",
                table: "Newses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleEng",
                table: "Newses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionArm",
                table: "Courses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEng",
                table: "Courses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BecomeTeachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CourseId = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    File = table.Column<byte[]>(type: "bytea", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    Modified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BecomeTeachers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BecomeTeachers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "RegisterForCourses");

            migrationBuilder.DropColumn(
                name: "DescriptionArm",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "DescriptionEng",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "TitleArm",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "TitleEng",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "DescriptionArm",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DescriptionEng",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "ParentPhoneNumber",
                table: "RegisterForCourses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TitleEng",
                table: "Courses",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "TitleArm",
                table: "Courses",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Newses",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Newses",
                type: "text",
                nullable: true);
        }
    }
}
