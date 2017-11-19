using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CSHomeworkAPI.Migrations
{
    public partial class CSHomeworkDBIUpdatingQuestionsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassName",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Cols",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CorrectAnswer",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Max",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "MaxLength",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Min",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "MinLength",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Pattern",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "PlaceHolder",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Rows",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Questions");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Questions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Questions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Label",
                table: "Questions");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Questions",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "ClassName",
                table: "Questions",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cols",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CorrectAnswer",
                table: "Questions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Explanation",
                table: "Questions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Max",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaxLength",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Min",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinLength",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pattern",
                table: "Questions",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceHolder",
                table: "Questions",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rows",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Questions",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
