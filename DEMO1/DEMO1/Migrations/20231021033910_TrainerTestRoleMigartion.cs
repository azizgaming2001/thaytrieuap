using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DEMO1.Migrations
{
    /// <inheritdoc />
    public partial class TrainerTestRoleMigartion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "Varchar(50)", nullable: true),
                    Description = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Status = table.Column<int>(type: "Integer", nullable: false, defaultValue: 1),
                    CreateAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            
        }
    }
}
