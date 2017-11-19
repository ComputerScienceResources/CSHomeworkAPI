using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CSHomeworkAPI.Migrations
{
    public partial class CSHomeworkDBIAddingQuestionToTypeJoin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Questions");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Questions_Types_Id",
            //    table: "Questions",
            //    column: "Id",
            //    principalTable: "Types",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Types_Id",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Questions",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
