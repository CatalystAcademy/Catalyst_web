using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalyst_web.Migrations
{
    /// <inheritdoc />
    public partial class romvedSomeProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumSections_Curriculums_CurriculumId",
                table: "CurriculumSections");

            migrationBuilder.DropIndex(
                name: "IX_CurriculumSections_CurriculumId",
                table: "CurriculumSections");

            migrationBuilder.DropColumn(
                name: "CurriculumId",
                table: "CurriculumSections");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CurriculumId",
                table: "CurriculumSections",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumSections_CurriculumId",
                table: "CurriculumSections",
                column: "CurriculumId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumSections_Curriculums_CurriculumId",
                table: "CurriculumSections",
                column: "CurriculumId",
                principalTable: "Curriculums",
                principalColumn: "Id");
        }
    }
}
