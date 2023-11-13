using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DEMO1.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesDbCreateChangeTypeDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Category",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Category",
                type: "Integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "Interger");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteAt",
                table: "Category",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Category",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdateAt",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Category",
                type: "Interger",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "Integer");

            migrationBuilder.AlterColumn<string>(
                name: "DeleteAt",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "CreateAt",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }
    }
}
