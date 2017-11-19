using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CSHomeworkAPI.Migrations
{
    public partial class CSHomeworkDBAddQuestionOptionsEntity3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionOptionID",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "QuestionOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionOptions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionOptionID",
                table: "Questions",
                column: "QuestionOptionID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionOptions_QuestionOptionID",
                table: "Questions",
                column: "QuestionOptionID",
                principalTable: "QuestionOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionOptions_QuestionOptionID",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "QuestionOptions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionOptionID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionOptionID",
                table: "Questions");
        }
    }
}
